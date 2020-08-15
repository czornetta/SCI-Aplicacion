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
    public partial class FControlesObservados : Form, IIdiomaObservador
    {
        NIdioma nIdioma = new NIdioma();
        Dictionary<string, string> diccionario;

        NMatrizControl nMatrizControl = new NMatrizControl();
        NControlInternoObservado nControlInterno = new NControlInternoObservado();
        //NRiesgo nRiesgo = new NRiesgoPropuesto();

        MatrizControl matrizControl;
        ControlInternoObservado objCRUD;
    
        public FControlesObservados()
        {
            InitializeComponent();
            ActualizarIdioma(Sesion.Instancia.Idioma);
            Inicializar();
        }

        private void UpdGrillaControlInterno()
        {
            try
            {
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = nMatrizControl.GetControlesInternosObs(matrizControl,Sesion.Instancia.Usuario.AreaNegocio);

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
            matrizControl = nMatrizControl.GetMatrizControlDefinicion();


            if (matrizControl != null)
            {

                UpdGrillaControlInterno();
            }

            SetearCombos();
            LimpiarCampos();

            button1.Enabled = false;
            button3.Enabled = false;

        }

        private void LimpiarCampos()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox6.Text = null;

            comboBox1.Text = null;
            comboBox2.Text = null;
        }


        private void SetearCombos()
        {
            // Tipo de Control
            comboBox1.Items.Clear();
            foreach (var l in (new NTipoControl()).GetTiposControles())
            {
                comboBox1.Items.Add(l);
            }
            comboBox1.Text = null;

            // Periodicidad
            comboBox2.Items.Clear();
            foreach (var l in (new NPeriodicidadControl()).GetPeriodicidadControles())
            {
                comboBox2.Items.Add(l);
            }
            comboBox2.Text = null;

        }

        private void Asignar()
        {
            if (textBox1.Text != "")
            {
                objCRUD.Id = Convert.ToInt16(textBox1.Text);
            }

            if (textBox2.Text == "")
            {
                throw new Exception(diccionario["msg_nombre_null"]);
            }

            if (textBox3.Text == "")
            {
                throw new Exception(diccionario["msg_descripcion_null"]);
            }

            if (comboBox1.SelectedItem == null)
            {
                throw new Exception(diccionario["msg_tipo_control_null"]);
            }

            if (comboBox2.SelectedItem == null)
            {
                throw new Exception(diccionario["msg_periodicidad_null"]);
            }

            objCRUD.Nombre = textBox2.Text;
            objCRUD.Descripcion = textBox3.Text;
            objCRUD.Tipo = (TipoControl)comboBox1.SelectedItem;
            objCRUD.Periodicidad = (PeriodicidadControl)comboBox2.SelectedItem;
            objCRUD.Comentario = textBox4.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                Asignar();

                nControlInterno.ProponerControlInterno(objCRUD);

                LimpiarCampos();
                UpdGrillaControlInterno();

                MessageBox.Show(diccionario["msg_control_propuesto"]);
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

                nControlInterno.CancelarControlInterno(objCRUD);

                LimpiarCampos();
                UpdGrillaControlInterno();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            textBox2.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[1].Value);
            textBox3.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[2].Value);
            textBox6.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[5].Value);
            textBox5.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[6].Value);
            textBox4.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[7].Value);

            comboBox1.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[3].Value);
            comboBox2.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[4].Value);

            button1.Enabled = true;
            button3.Enabled = true;

            objCRUD = (ControlInternoObservado)dataGridView2.SelectedRows[0].DataBoundItem;
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

        private void FControlesObservados_Load(object sender, EventArgs e)
        {
            Sesion.Instancia.SuscribirObservador(this);
        }

        private void FControlesObservados_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.Instancia.DesuscribirObservador(this);
        }
    }
}
