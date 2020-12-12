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
using Servicios.Seguridad;
using Negocio.Seguridad;

namespace Presentacion.Seguridad
{
    public partial class FAreaNegocio : Form, IIdiomaObservador
    {
        NIdioma nIdioma = new NIdioma();
        Dictionary<string, string> diccionario;

        NAreaNegocio nAreaNegocio = new NAreaNegocio();
        AreaNegocio objCRUD;

        public FAreaNegocio()
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
                dataGridView1.DataSource = nAreaNegocio.GetAreasNegocio();

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
            textBox3.Text = null;

            UpdGrilla();
            
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void Asignar()
        {
            if (textBox1.Text != "")
            {
                objCRUD.Id = Convert.ToInt16(textBox1.Text);
            }

            objCRUD.Nombre = textBox3.Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                objCRUD = new AreaNegocio();
                Asignar();
                nAreaNegocio.AgregarAreaNegocio(objCRUD);

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
                nAreaNegocio.ModificarAreaNegocio(objCRUD);

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
                nAreaNegocio.BorrarAreaNegocio(objCRUD);

                Inicializar();
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
                textBox3.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);

                objCRUD = (AreaNegocio)dataGridView1.SelectedRows[0].DataBoundItem;

                button2.Enabled = true;
                button3.Enabled = true;
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
