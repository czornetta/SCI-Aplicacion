using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.MultiIdioma;
using Entidades.MuiltiIdioma;
using Servicios.MultiIdioma;
using Entidades.Seguridad;
using Negocio.Seguridad;
using Servicios.Seguridad;
using Negocio.DefMatrizControl;
using Entidades.DefMatrizControl;

namespace Presentacion.DefMatrizControl
{
    public partial class FRiesgosObservados : Form, IIdiomaObservador
    {
        NIdioma nIdioma = new NIdioma();
        Dictionary<string, string> diccionario;

        NMatrizControl nMatrizControl = new NMatrizControl();
        NAreaNegocio nAreaNegocio = new NAreaNegocio();
        NRiesgoObservado nRiesgo = new NRiesgoObservado();

        RiesgoObservado objCRUD;
       

        public FRiesgosObservados()
        {
            InitializeComponent();
            ActualizarIdioma(Sesion.Instancia.Idioma);
            Inicializar();
        }

        private void UpdGrilla()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = nRiesgo.GetRiesgos(nMatrizControl.GetMatrizControlRelevamiento());

                //dataGridView1.Columns[4].Visible = false;
                //dataGridView1.Columns[5].Visible = false;
                //dataGridView1.Columns[6].Visible = false;
                //dataGridView1.Columns[7].Visible = false;
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
            MatrizControl matrizControl = nMatrizControl.GetMatrizControlRelevamiento();

            if (matrizControl != null)
            {
                SetearCombos();
                UpdGrilla();
            }
            
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            button1.Enabled = false;
            button2.Enabled = false;
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
        }

        private void Asignar()
        {
            
            if (textBox2.Text == "")
            {
                throw new Exception(diccionario["msg_nombre_null"]);
            }

            if (comboBox2.SelectedItem == null)
            {
                throw new Exception(diccionario["msg_clasificacion_null"]);
            }

            objCRUD.Nombre = textBox2.Text;
            objCRUD.Comentario = textBox5.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Asignar();
                
                nRiesgo.ProponerRiesgo(objCRUD);

                MessageBox.Show(diccionario["msg_riesgo_propuesto"]);
                Inicializar();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Asignar();
                nRiesgo.CancelarRiesgo(objCRUD);

                MessageBox.Show(diccionario["msg_riesgo_cancelado"]);
                Inicializar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                textBox2.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                comboBox1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                comboBox2.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                textBox3.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                textBox4.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                textBox5.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[6].Value);

                objCRUD = (RiesgoObservado)dataGridView1.SelectedRows[0].DataBoundItem;
                button1.Enabled = true;
                button2.Enabled = true;

            }
        }

        private void FRiesgosObservados_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.Instancia.DesuscribirObservador(this);
        }

        private void FRiesgosObservados_Load(object sender, EventArgs e)
        {
            Sesion.Instancia.SuscribirObservador(this);
        }
    }
}
