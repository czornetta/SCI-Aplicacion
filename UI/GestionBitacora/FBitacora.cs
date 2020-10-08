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
using Entidades.Seguridad;
using Servicios.Seguridad;
using Negocio.Seguridad;
using Entidades.MuiltiIdioma;
using Servicios.MultiIdioma;
using Entidades.GestionBitacora;
using Negocio.GestionBitacora;

namespace Presentacion.GestionBitacora
{
    public partial class FBitacora : Form, IIdiomaObservador
    {
        NIdioma nIdioma = new NIdioma();
        Dictionary<string, string> diccionario;

        NUsuario nUsuario = new NUsuario();

        NBitacora nBitacora = new NBitacora();

        public FBitacora()
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

                dataGridView1.DataSource = nBitacora.Registros((Usuario)comboBox1.SelectedItem
                                                            , comboBox2.Text
                                                            , dateTimePicker1.Value
                                                            , dateTimePicker2.Value);

                dataGridView1.Columns[1].Width=130;
                dataGridView1.Columns[2].Width = 200;
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
            comboBox1.Items.Clear();
            foreach (var l in nUsuario.Leer())
            {
                comboBox1.Items.Add(l);
            }
            comboBox1.Text = null;

            comboBox2.Items.Clear();
            foreach (var l in nBitacora.GetTiposRegistro())
            {
                comboBox2.Items.Add(l);
                comboBox2.SelectedItem = l;
            }
            //comboBox2.Text = null;

            dateTimePicker1.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            dateTimePicker2.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            dateTimePicker1.Value = DateTime.Today.AddDays(-7);
            UpdGrilla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdGrilla();
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

        private void FAreaNegocio_Load(object sender, EventArgs e)
        {
            Sesion.Instancia.SuscribirObservador(this);
        }

        private void FAreaNegocio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.Instancia.DesuscribirObservador(this);
        }
    }
}
