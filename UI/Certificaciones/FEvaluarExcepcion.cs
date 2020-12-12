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
    public partial class FEvaluarExcepcion : Form, IIdiomaObservador
    {
        NIdioma nIdioma = new NIdioma();
        Dictionary<string, string> diccionario;
        NMatrizControl nMatrizControl = new NMatrizControl();
        MatrizControl matrizControl;
        NCertificacion nCertificacion = new NCertificacion();
        Certificacion certificacion;
        //int index = -1;

        public FEvaluarExcepcion()
        {
            InitializeComponent();
            ActualizarIdioma(Sesion.Instancia.Idioma);
            Inicializar();
        }

        private void Inicializar()
        {
            matrizControl = nMatrizControl.GetMatrizControlActiva();
            SetearCombos();

            // Control
            textBox7.Text = "";
            textBox6.Text = "";
            comboBox2.Text = null;
            comboBox3.Text = null;

            // excepcion
            textBox2.Text = null;
            textBox3.Text = null;
            comboBox1.Text = null;
            button1.Enabled = false;
            button2.Enabled = false;
            
            // Incidente
            textBox5.Text = null;
            textBox4.Text = null;
            UpdGrilla();
        }

        private void UpdGrilla()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = nCertificacion.GetCertificaciones(matrizControl);
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void SetearCombos()
        {
            // Estado Excepcion
            comboBox1.DataSource = null;
            comboBox1.DataSource = nCertificacion.GetResultadosCertificaciones();

            // Tipo de Control
            comboBox3.Items.Clear();
            foreach (var l in (new NTipoControl()).GetTiposControles())
            {
                comboBox3.Items.Add(l);
            }
            comboBox3.Text = null;

            // Periodicidad
            comboBox2.Items.Clear();
            foreach (var l in (new NPeriodicidadControl()).GetPeriodicidadControles())
            {
                comboBox2.Items.Add(l);
            }
            comboBox2.Text = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                nCertificacion.AceptarExcepcion(certificacion);
                             
                MessageBox.Show(diccionario["msg_excepcion_aceptada"]);
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

                if (textBox1.Text == "")
                {
                    throw new Exception(diccionario["msg_ingresar_motivor"]);
                }

                certificacion.Incidente.Fecha = DateTime.Now;
                certificacion.Incidente.Descripcion = textBox1.Text;
                
                nCertificacion.RechazarExcepcion(certificacion);

                MessageBox.Show(diccionario["msg_excepcion_rechazada"]);
                Inicializar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void asignar(Certificacion cer)
        {
            try
            {
                certificacion = cer;
                textBox1.Text = "";

                // Control
                textBox7.Text = certificacion.ControlInterno.Nombre;
                textBox6.Text = certificacion.ControlInterno.Descripcion;
                comboBox2.Text = certificacion.ControlInterno.Periodicidad.Nombre;
                comboBox3.Text = certificacion.ControlInterno.Tipo.Nombre;

                if (certificacion.Excepcion.Descripcion != null)
                {
                    // excepcion
                    textBox2.Text = certificacion.Excepcion.Fecha.ToString();
                    textBox3.Text = certificacion.Excepcion.Descripcion.ToString();
                    comboBox1.Text = certificacion.Excepcion.Estado.Nombre;

                    if (comboBox1.Text == "Solicitada")
                    {
                        textBox1.Enabled = true;
                        button1.Enabled = true;
                        button2.Enabled = true;
                    }
                    else
                    {
                        textBox1.Enabled = false;
                        button1.Enabled = false;
                        button2.Enabled = false;
                    }
                }
                else
                {
                    textBox2.Text = null;
                    textBox3.Text = null;
                    comboBox1.Text = null;
                    button1.Enabled = false;
                    button2.Enabled = false;
                }

                if (certificacion.Incidente.Descripcion != null)
                {
                    // Incidente
                    textBox5.Text = certificacion.Incidente.Fecha.ToString();
                    textBox4.Text = certificacion.Incidente.Descripcion;
                }
                else
                {
                    textBox5.Text = null;
                    textBox4.Text = null;
                }
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
                if (e.RowIndex >= 0)
                {
                    asignar((Certificacion)dataGridView1.SelectedRows[0].DataBoundItem);
                }
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

                    foreach (Control i in item.Controls)
                    {
                        if (i.Tag != null)
                        {
                            i.Text = diccionario[i.Tag.ToString()];
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FEvaluarExcepcion_Load(object sender, EventArgs e)
        {
            Sesion.Instancia.SuscribirObservador(this);
        }

        private void FEvaluarExcepcion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.Instancia.DesuscribirObservador(this);
        }
    }
}
