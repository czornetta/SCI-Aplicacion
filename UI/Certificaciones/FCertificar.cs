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
using Entidades.Certificaciones;
using Negocio.Certificaciones;
using Entidades.DefMatrizControl;
using Negocio.DefMatrizControl;

namespace Presentacion.Certificaciones
{
    public partial class FCertificar : Form, IIdiomaObservador
    {
        NIdioma nIdioma = new NIdioma();
        Dictionary<string, string> diccionario;
        NMatrizControl nMatrizControl = new NMatrizControl();
        MatrizControl matrizControl;
        ControlInternoAceptado controlInterno;
        NCertificacion nCertificacion = new NCertificacion();
        Certificacion certificacion;

        public FCertificar()
        {
            InitializeComponent();
            ActualizarIdioma(Sesion.Instancia.Idioma);
            Inicializar();
        }

        private void Inicializar()
        {
            matrizControl = nMatrizControl.GetMatrizControlActiva();
            comboBox1.DataSource = null;
            comboBox1.DataSource = nCertificacion.GetResultadosCertificaciones();
            UpdGrillaControles();
        }

        private void UpdGrillaControles()
        {
            try
            {
                dataGridView1.DataSource = null;

                dataGridView1.DataSource = nMatrizControl.GetControlesInternos(matrizControl, Sesion.Instancia.Usuario.AreaNegocio);
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                UpdGrillaCertificaciones();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void UpdGrillaCertificaciones()
        {
            try
            {

                dataGridView2.DataSource = null;
                
                if (controlInterno != null)
                {
                    dataGridView2.DataSource = nCertificacion.GetCertificaciones(controlInterno);
                    dataGridView2.Columns[0].Visible = false;
                    dataGridView2.Columns[2].Visible = false;
                    //dataGridView2.Columns[5].Visible = false;
                    //dataGridView2.Columns[6].Visible = false;
                    dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGridView2.MultiSelect = false;
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (controlInterno == null)
                {
                    throw new Exception(diccionario["msg_selecionar_control"]);
                }

                if (comboBox1.SelectedItem == null)
                {
                    throw new Exception(diccionario["msg_selecionar_resultado"]);
                }
                                
                certificacion = new Certificacion();
                certificacion.ControlInterno = controlInterno;
                certificacion.Resultado = (ResultadoCertificacion)comboBox1.SelectedItem;
                certificacion.Fecha = DateTime.Now;
                certificacion.Usuario = Sesion.Instancia.Usuario;

                if (textBox1.Text == "" && certificacion.Resultado.Id != 1)
                {
                    throw new Exception(diccionario["msg_ingresar_motivo"]);
                }

                if (certificacion.Resultado.Id == 2 )
                {
                    certificacion.Incidente.Fecha = certificacion.Fecha;
                    certificacion.Incidente.Descripcion = textBox1.Text;
                }

                if (certificacion.Resultado.Id == 3)
                {
                    certificacion.Excepcion.Fecha = certificacion.Fecha;
                    certificacion.Excepcion.Descripcion = textBox1.Text;
                    certificacion.Excepcion.Estado.Id = 1;
                }

                nCertificacion.AddCertificacion(certificacion);

                UpdGrillaCertificaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            controlInterno = (ControlInternoAceptado)dataGridView1.SelectedRows[0].DataBoundItem;
            UpdGrillaCertificaciones();
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

        private void FCertificar_Load(object sender, EventArgs e)
        {
            Sesion.Instancia.SuscribirObservador(this);
        }

        private void FCertificar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.Instancia.DesuscribirObservador(this);
        }
    }
}
