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
    public partial class FIdioma : Form, IIdiomaObservador
    {
        NIdioma nIdioma = new NIdioma();
        
        Idioma idioma;

        public FIdioma()
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
                dataGridView1.DataSource = nIdioma.GetIdiomas();
                dataGridView1.Columns[3].Visible = false;
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
            checkBox1.Checked = false;

            UpdGrilla();

        }

        private void Asignar()
        {
            if (textBox1.Text != "")
            {
                idioma.Id = Convert.ToInt16(textBox1.Text);
            }
            idioma.Nombre = textBox2.Text;
            idioma.Principal = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                idioma = new Idioma();
                Asignar();
                nIdioma.AgregarIdioma(idioma);

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
                nIdioma.ModificarIdioma(idioma);

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
                nIdioma.BorrarIdioma(idioma);

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
            checkBox1.Checked = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[2].Value);

            idioma = new Idioma();

        }

        public void ActualizarIdioma(Idioma idioma)
        {

            Dictionary<string, string> diccionario = nIdioma.GetDiccionario(idioma);

            try
            {
                label2.Text = diccionario[label2.Tag.ToString()];
                checkBox1.Text = diccionario[checkBox1.Tag.ToString()];
                button1.Text = diccionario[button1.Tag.ToString()];
                button2.Text = diccionario[button2.Tag.ToString()];
                button3.Text = diccionario[button3.Tag.ToString()];

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FIdioma_Load(object sender, EventArgs e)
        {
            Sesion.Instancia.SuscribirObservador(this);
        }

        private void FIdioma_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.Instancia.DesuscribirObservador(this);
        }
    }
}
