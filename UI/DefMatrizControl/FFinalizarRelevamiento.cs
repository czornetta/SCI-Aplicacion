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
    public partial class FFinalizarRelevamiento : Form, IIdiomaObservador
    {
        NIdioma nIdioma = new NIdioma();
        Dictionary<string, string> diccionario;

        NMatrizControl nMatrizControl = new NMatrizControl();
        NRiesgo nRiesgo = new NRiesgoPropuesto();
        MatrizControl matrizControl;

        IList<EstadoMatrizControl> estadosMatrizControl;

        public FFinalizarRelevamiento()
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
                dataGridView1.DataSource = nMatrizControl.GetRiesgosResumenAreaNegocio(matrizControl);

                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;

                dataGridView2.DataSource = null;
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView2.MultiSelect = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Inicializar()
        {
            matrizControl = nMatrizControl.GetMatrizControlRelevamiento();

            if (matrizControl != null)
            {
                textBox1.Text = matrizControl.Id.ToString();
                textBox3.Text = matrizControl.Periodo.ToString();

                // Estados
                comboBox3.Items.Clear();

                estadosMatrizControl = (new NEstadoMatrizControl()).GetEstados();

                foreach (var l in estadosMatrizControl)
                {
                    comboBox3.Items.Add(l);
                }
                comboBox3.Text = matrizControl.Estado.Nombre;

                UpdGrilla();
            }
            else
            {
                textBox1.Text = null;
                textBox3.Text = null;
                comboBox3.Text = null;
                dataGridView1.DataSource = null;
                dataGridView2.DataSource = null;
                button1.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in dataGridView1.Rows)
                {
                    EstadoRiesgo estado = (EstadoRiesgo)item.Cells[1].Value;

                    if (estado.Clase.Equals(typeof(RiesgoPropuesto).ToString()) || estado.Clase.Equals(typeof(RiesgoObservado).ToString()))
                    {
                        throw new Exception(diccionario["msg_riesgo_no_aceptado"]);
                    } 
                }

                matrizControl.Estado = estadosMatrizControl.FirstOrDefault(x => x.Id == 2);

                nMatrizControl.ModificarMatrizControl(matrizControl);
                
                Inicializar();

                MessageBox.Show(diccionario["msg_relevamiento_finalizado"]);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                AreaNegocio areaNegocio = (AreaNegocio)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                EstadoRiesgo estadoRiesgo = (EstadoRiesgo)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = nMatrizControl.GetRiesgosAreaNegocio(matrizControl, areaNegocio, estadoRiesgo);

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

        private void FFinalizarRelevamiento_Load(object sender, EventArgs e)
        {
            Sesion.Instancia.SuscribirObservador(this);
        }

        private void FFinalizarRelevamiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.Instancia.DesuscribirObservador(this);
        }

        
    }
}
