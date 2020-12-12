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
    public partial class FMatrizControlInternoVigente : Form, IIdiomaObservador
    {
        NIdioma nIdioma = new NIdioma();
        Dictionary<string, string> diccionario;

        NMatrizControl nMatrizControl = new NMatrizControl();
        NRiesgoAceptado nRiesgo = new NRiesgoAceptado();
        NControlInternoAceptado nControlInterno = new NControlInternoAceptado();

        MatrizControl matrizControl;
        AreaNegocio areaNegocio;
        Riesgo riesgo;
        IList<EstadoMatrizControl> estadosMatrizControl;

        public FMatrizControlInternoVigente()
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
                dataGridView1.DataSource = nMatrizControl.GetResumen(matrizControl);

                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void UpdGrillaRiesgos()
        {
            try
            {
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = nRiesgo.GetRiesgosAreaNegocio(matrizControl, areaNegocio);


                dataGridView2.Columns[2].Visible = false;
                dataGridView2.Columns[4].Visible = false;
                dataGridView2.Columns[5].Visible = false;
                dataGridView2.Columns[6].Visible = false;
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView2.MultiSelect = false;

                dataGridView3.DataSource = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void UpdGrillaControlesInternos()
        {
            try
            {
                dataGridView3.DataSource = null;
                dataGridView3.DataSource = nControlInterno.GetControlesInternos(riesgo);

                dataGridView3.Columns[0].Visible = false;
                dataGridView3.Columns[5].Visible = false;
                dataGridView3.Columns[6].Visible = false;
                dataGridView3.Columns[7].Visible = false;
                dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView3.MultiSelect = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Inicializar()
        {
            matrizControl = nMatrizControl.GetMatrizControlActiva();

            if (matrizControl != null)
            {
                SetearCombos();
                textBox1.Text = matrizControl.Id.ToString();
                textBox3.Text = matrizControl.Periodo.ToString();
                comboBox1.Text = matrizControl.Estado.ToString();
                UpdGrilla();
            }
            else
            {
                textBox1.Text = null;
                textBox3.Text = null;
                comboBox1.Text = null;
                dataGridView1.DataSource = null;
                dataGridView2.DataSource = null;
            }

        }

        private void SetearCombos()
        {
            // Estados
            comboBox1.Items.Clear();
            estadosMatrizControl = (new NEstadoMatrizControl()).GetEstados();

            foreach (var l in estadosMatrizControl)
            {
                comboBox1.Items.Add(l);
            }
        }

         private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                areaNegocio = (AreaNegocio)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                UpdGrillaRiesgos();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                riesgo = (RiesgoAceptado)dataGridView2.SelectedRows[0].DataBoundItem;
                UpdGrillaControlesInternos();
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

        private void FMatrizControlInternoVigente_Load(object sender, EventArgs e)
        {
            Sesion.Instancia.SuscribirObservador(this);
        }

        private void FMatrizControlInternoVigente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.Instancia.DesuscribirObservador(this);
        }
    }
}
