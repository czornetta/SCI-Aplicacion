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
using Servicios.Seguridad;
using Servicios.MultiIdioma;

namespace Presentacion.MultiIdioma
{
    public partial class FTraduccion : Form, IIdiomaObservador
    {
        NIdioma nIdioma = new NIdioma();
        Traduccion traduccion;

        public FTraduccion()
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
                dataGridView1.DataSource = nIdioma.GetTraducciones();

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
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            SetearComboIdiomas();
            SetearComboEtiquetas();

            UpdGrilla();

        }

        private void SetearComboIdiomas()
        {
            comboBox1.Items.Clear();

            foreach (var l in nIdioma.GetIdiomas())
            {
                comboBox1.Items.Add(l);
            }

            comboBox1.Text = null;
        }

        private void SetearComboEtiquetas()
        {
            comboBox2.Items.Clear();

            foreach (var l in nIdioma.GetEtiquetas())
            {
                comboBox2.Items.Add(l);
            }

            comboBox2.Text = null;
        }

        private void Asignar()
        {
            try
            {
                traduccion.Idioma = (Idioma)comboBox1.SelectedItem;
                traduccion.Etiqueta = (Etiqueta)comboBox2.SelectedItem;
                traduccion.Texto = textBox1.Text;
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
                traduccion = new Traduccion();
                Asignar();
                nIdioma.AgregarTraduccion(traduccion);

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
                nIdioma.ModificarTraduccion(traduccion);

                Inicializar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                Asignar();
                nIdioma.BorrarTraduccion(traduccion);

                Inicializar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            comboBox1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            comboBox2.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;

            traduccion = new Traduccion();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Inicializar();
        }

        public void ActualizarIdioma(Idioma idioma)
        {

            Dictionary<string, string> diccionario = nIdioma.GetDiccionario(idioma);

            try
            {
                label1.Text = diccionario[label1.Tag.ToString()];
                label2.Text = diccionario[label2.Tag.ToString()];
                label3.Text = diccionario[label3.Tag.ToString()];
                button1.Text = diccionario[button1.Tag.ToString()];
                button2.Text = diccionario[button2.Tag.ToString()];
                button3.Text = diccionario[button3.Tag.ToString()];
                button4.Text = diccionario[button4.Tag.ToString()];
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FTraduccion_Load(object sender, EventArgs e)
        {
            Sesion.Instancia.SuscribirObservador(this);
        }

        private void FTraduccion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.Instancia.DesuscribirObservador(this);
        }
    }
}
