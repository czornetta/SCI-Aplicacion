using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.MuiltiIdioma;
using Servicios.MultiIdioma;
using Negocio.MultiIdioma;
using Servicios.Seguridad;
using Negocio.Seguridad;
using Entidades.DefMatrizControl;
using Negocio.DefMatrizControl;
using Entidades.Auditoria;
using Negocio.Auditoria;
using Entidades.Seguridad;

namespace Presentacion.Auditoria
{
    public partial class FRiesgoAudit : Form, IIdiomaObservador
    {
        NIdioma nIdioma = new NIdioma();
        Dictionary<string, string> diccionario;

        NMatrizControl nMatrizControl = new NMatrizControl();
        NAreaNegocio nAreaNegocio = new NAreaNegocio();

        NRiesgoAudit nRiesgoAudit = new NRiesgoAudit();
        RiesgoAudit riesgoAudit;
        

        public FRiesgoAudit()
        {
            InitializeComponent();
            ActualizarIdioma(Sesion.Instancia.Idioma);
            Inicializar();
        }

        public void UpdGrilla()
        {
            try
            {
                RiesgoAudit riesgoAuditFiltro = new RiesgoAudit();

                if (textBox1.Text != "")
                {
                    riesgoAuditFiltro.IdRiesgo = Convert.ToInt16(textBox1.Text);
                }

                if (textBox2.Text != "")
                {
                    riesgoAuditFiltro.Nombre = textBox2.Text;
                }

                riesgoAuditFiltro.AreaNegocio = (AreaNegocio)comboBox1.SelectedItem;
                riesgoAuditFiltro.Clasificacion = (ClasificacionRiesgo)comboBox2.SelectedItem;
                riesgoAuditFiltro.MatrizControl = (MatrizControl)comboBox3.SelectedItem;

                dataGridView1.DataSource = null;

                dataGridView1.DataSource = nRiesgoAudit.GetRiesgosAudit(riesgoAuditFiltro);
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[10].Width = 140;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Inicializar()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            SetearCombos();
            UpdGrilla();
        }

        private void SetearCombos()
        {
            // Areas de Negocio
            comboBox1.Items.Clear();
            foreach (var l in nAreaNegocio.GetAreasNegocio())
            {
                comboBox1.Items.Add(l);
            }
            comboBox1.Text = null;

            // Clasificaciones
            comboBox2.Items.Clear();

            IList<ClasificacionRiesgo> clasificacionRiesgos = (new NClasificacionRiesgo()).GetClasificacionesRiesgo();

            foreach (var l in clasificacionRiesgos)
            {
                comboBox2.Items.Add(l);
            }
            comboBox2.Text = null;

            // Periodo
            comboBox3.Items.Clear();

            IList<MatrizControl> periodos = nMatrizControl.GetMatricesControl();

            foreach (var l in periodos)
            {
                comboBox3.Items.Add(l);
            }
            comboBox3.Text = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (riesgoAudit == null)
                {
                    throw new Exception(diccionario["msg_seleccion_estado"]);
                }

                
                if (!(nRiesgoAudit.IsAlive(riesgoAudit)))
                {
                    throw new Exception(diccionario["msg_estado_u"]);
                }

                nRiesgoAudit.RestoreRiesgo(riesgoAudit);
                MessageBox.Show(diccionario["msg_riesgo_restaurado"]);

                UpdGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            riesgoAudit = (RiesgoAudit)dataGridView1.SelectedRows[0].DataBoundItem;
        }

        public void ActualizarIdioma(Idioma idioma)
        {

            diccionario = nIdioma.GetDiccionario(idioma);

            try
            {
                foreach (Control item in this.Controls)
                {
                    if (item.Tag != null)
                    {
                        item.Text = diccionario[item.Tag.ToString()];
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FRiesgoAudit_Load(object sender, EventArgs e)
        {
            Sesion.Instancia.SuscribirObservador(this);
        }

        private void FRiesgoAudit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.Instancia.DesuscribirObservador(this);
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            UpdGrilla();
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            UpdGrilla();
        }

        private void comboBox1_Validated(object sender, EventArgs e)
        {
            UpdGrilla();
        }

        private void comboBox3_Validated(object sender, EventArgs e)
        {
            UpdGrilla();
        }

        private void comboBox2_Validated(object sender, EventArgs e)
        {
            UpdGrilla();
        }
    }
}
