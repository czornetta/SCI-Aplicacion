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
    public partial class FEtiqueta : Form, IIdiomaObservador
    {
        NIdioma nIdioma = new NIdioma();
        Etiqueta etiqueta;

        public FEtiqueta()
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
                dataGridView1.DataSource = nIdioma.GetEtiquetas();

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

            UpdGrilla();

        }

        private void Asignar()
        {
            if (textBox1.Text != "")
            {
                etiqueta.Id = Convert.ToInt16(textBox1.Text);
            }
            etiqueta.Nombre = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                etiqueta = new Etiqueta();
                Asignar();
                nIdioma.AgregarEtiqueta(etiqueta);

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
                nIdioma.ModificarEtiqueta(etiqueta);

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
                nIdioma.BorrarEtiqueta(etiqueta);

                Inicializar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            textBox2.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);

            etiqueta = new Etiqueta();

        }

        public void ActualizarIdioma(Idioma idioma)
        {

            Dictionary<string, string> diccionario = nIdioma.GetDiccionario(idioma);

            try
            {
                label2.Text = diccionario[label2.Tag.ToString()];
                button1.Text = diccionario[button1.Tag.ToString()];
                button2.Text = diccionario[button2.Tag.ToString()];
                button3.Text = diccionario[button3.Tag.ToString()];

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FEtiqueta_Load(object sender, EventArgs e)
        {
            Sesion.Instancia.SuscribirObservador(this);
        }

        private void FEtiqueta_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.Instancia.DesuscribirObservador(this);
        }
    }
}
