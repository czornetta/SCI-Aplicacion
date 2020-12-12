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
using Servicios.Seguridad;
using Negocio.DefMatrizControl;
using Entidades.DefMatrizControl;

namespace Presentacion.DefMatrizControl
{
    public partial class FMatrizControlInterno : Form, IIdiomaObservador
    {
        NIdioma nIdioma = new NIdioma();
        Dictionary<string, string> diccionario;

        NMatrizControl nMatrizControl = new NMatrizControl();

        MatrizControl objCRUD;
    
        public FMatrizControlInterno()
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
                dataGridView1.DataSource = nMatrizControl.GetMatricesControl();

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

            if (nMatrizControl.GetMatricesControl().Where(x => x.Estado.Id != 4).Count() > 0)
            {
                button1.Enabled = false;
            }

            textBox1.Text = null;
            textBox3.Text = null;

            UpdGrilla();

        }

        private void Asignar()
        {
            if (textBox1.Text != "")
            {
                objCRUD.Id = Convert.ToInt16(textBox1.Text);
            }

            if (textBox3.Text != "")
            {
                objCRUD.Periodo = Convert.ToInt16(textBox3.Text);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                objCRUD = new MatrizControl();
                Asignar();
                nMatrizControl.AgregarMatrizControl(objCRUD);

                Inicializar();

                MessageBox.Show(diccionario["msg_periodo_creado"]);
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
                nMatrizControl.ModificarMatrizControl(objCRUD);

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
                nMatrizControl.BorrarMatrizControl(objCRUD);

                Inicializar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBox1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            //textBox3.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);

            //objCRUD = (MatrizControl)dataGridView1.SelectedRows[0].DataBoundItem;

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

        private void FMatrizControlInterno_Load(object sender, EventArgs e)
        {
            Sesion.Instancia.SuscribirObservador(this);
        }

        private void FMatrizControlInterno_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.Instancia.DesuscribirObservador(this);
        }
    }
}
