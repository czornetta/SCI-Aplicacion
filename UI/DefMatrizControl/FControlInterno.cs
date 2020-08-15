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
    public partial class FControlInterno : Form, IIdiomaObservador
    {
        NIdioma nIdioma = new NIdioma();
        Dictionary<string, string> diccionario;

        NControlInternoPropuesto nControlInterno = new NControlInternoPropuesto();
        NRiesgoAceptado nRiesgo = new NRiesgoAceptado();
        NMatrizControl nMatrizControl = new NMatrizControl();

        Riesgo riesgo;
        ControlInternoPropuesto objCRUD;

        public FControlInterno()
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
                dataGridView1.DataSource = nRiesgo.GetRiesgosAreaNegocio(nMatrizControl.GetMatrizControlDefinicion(),Sesion.Instancia.Usuario.AreaNegocio);

                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void UpdGrillaControlInterno()
        {
            try
            {
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = nControlInterno.GetControlesInternos(riesgo);

                dataGridView2.Columns[5].Visible = false;
                dataGridView2.Columns[6].Visible = false;
                dataGridView2.Columns[7].Visible = false;
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
            MatrizControl matrizControl = nMatrizControl.GetMatrizControlDefinicion();

            if (matrizControl != null)
            {
                SetearCombos();
                UpdGrilla();
            }

            LimpiarCampos();

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
        }

        private void LimpiarCampos()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;

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

            if (textBox1.Text != "")
            {
                objCRUD.Id = Convert.ToInt16(textBox1.Text);
                objCRUD.Tipo = (TipoControl)comboBox1.SelectedItem;
                objCRUD.Periodicidad = (PeriodicidadControl)comboBox2.SelectedItem;
            }
            else
            {
                objCRUD = new ControlInternoPropuesto(riesgo
                                           , (TipoControl)comboBox1.SelectedItem
                                           , (PeriodicidadControl)comboBox2.SelectedItem);
            }
            objCRUD.Nombre = textBox2.Text;
            objCRUD.Descripcion = textBox3.Text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                Asignar();
                
                nControlInterno.AgregarControlInterno(objCRUD);

                LimpiarCampos();
                UpdGrillaControlInterno();

                MessageBox.Show(diccionario["msg_control_interno_registrado"]);
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
                nControlInterno.ModificarControlInterno(objCRUD);

                LimpiarCampos();
                UpdGrillaControlInterno();
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
                nControlInterno.BorrarControlInterno(objCRUD);

                LimpiarCampos();
                UpdGrillaControlInterno();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            riesgo = (RiesgoAceptado)dataGridView1.Rows[e.RowIndex].DataBoundItem;

            LimpiarCampos();
            UpdGrillaControlInterno();

            textBox2.Enabled = true;
            textBox3.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            button1.Enabled = true;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            textBox2.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[1].Value);
            textBox3.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[2].Value);
            comboBox1.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[3].Value);
            comboBox2.Text = Convert.ToString(dataGridView2.Rows[e.RowIndex].Cells[4].Value);
            
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

        private void FControlInterno_Load(object sender, EventArgs e)
        {
            Sesion.Instancia.SuscribirObservador(this);
        }

        private void FControlInterno_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.Instancia.DesuscribirObservador(this);
        }

        
    }
}
