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
using Negocio.Seguridad;
using Entidades.Seguridad;
using Negocio.DefMatrizControl;
using Entidades.DefMatrizControl;

namespace Presentacion.DefMatrizControl
{
    public partial class FRiesgo : Form, IIdiomaObservador
    {
        NIdioma nIdioma = new NIdioma();
        Dictionary<string, string> diccionario;

        NMatrizControl nMatrizControl = new NMatrizControl();
        NAreaNegocio nAreaNegocio = new NAreaNegocio();
        NRiesgoPropuesto nRiesgo = new NRiesgoPropuesto();

        RiesgoPropuesto objCRUD;


        public FRiesgo()
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
                dataGridView1.DataSource = nRiesgo.GetRiesgos(nMatrizControl.GetMatrizControlRelevamiento());

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
            MatrizControl matrizControl = nMatrizControl.GetMatrizControlRelevamiento();

            if (matrizControl != null)
            {
                textBox3.Text = matrizControl.ToString();
                comboBox1.Enabled = true;
                SetearCombos();

                UpdGrilla();
            }
            else
            {
                textBox3.Text = null;
                button1.Enabled = false;
                
                comboBox1.Enabled = true;
            }

            textBox1.Text = null;
            textBox2.Text = null;

            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void SetearCombos()
        {
            // Areas de Negocio
            comboBox1.Items.Clear();
            foreach (var l in nAreaNegocio.GetAreasNegocio())
            {
                comboBox1.Items.Add(l);
            }
            comboBox1.Text = null;

            // Clasificaciones
            comboBox2.Items.Clear();

            IList<ClasificacionRiesgo> clasificacionRiesgos = (new NClasificacionRiesgo()).GetClasificacionesRiesgo();

            foreach (var l in clasificacionRiesgos)
            {
                comboBox2.Items.Add(l);
            }
            comboBox2.Text = null;

        }

        private void Asignar()
        {
            
            if (textBox2.Text=="")
            {
                throw new Exception(diccionario["msg_nombre_null"]);
            }

            if (comboBox1.SelectedItem == null)
            {
                throw new Exception(diccionario["msg_area_null"]);
            }

            if (comboBox2.SelectedItem == null)
            {
                throw new Exception(diccionario["msg_clasificacion_null"]);
            }

            if (textBox1.Text != "")
            {
                objCRUD.Id = Convert.ToInt16(textBox1.Text);
                objCRUD.Clasificacion = (ClasificacionRiesgo)comboBox2.SelectedItem;
            }
            else
            {
                objCRUD = new RiesgoPropuesto(nMatrizControl.GetMatrizControlRelevamiento()
                                            , (AreaNegocio)comboBox1.SelectedItem
                                            ,(ClasificacionRiesgo)comboBox2.SelectedItem);
                
            }

            objCRUD.Nombre = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                Asignar();
                textBox1.Text = "";
                nRiesgo.AgregarRiesgo(objCRUD);

                Inicializar();

                MessageBox.Show(diccionario["msg_riesgo_registrado"]);
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
                nRiesgo.ModificarRiesgo(objCRUD);

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
                nRiesgo.BorrarRiesgo(objCRUD);

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
            comboBox1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            comboBox1.Enabled = false;
            comboBox2.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            textBox3.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);

            objCRUD = (RiesgoPropuesto)dataGridView1.SelectedRows[0].DataBoundItem;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;

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

        private void FRiesgo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.Instancia.DesuscribirObservador(this);
        }

        private void FRiesgo_Load(object sender, EventArgs e)
        {
            Sesion.Instancia.SuscribirObservador(this);
        }


    }
}
