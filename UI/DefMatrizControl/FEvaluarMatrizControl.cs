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
using Negocio.Seguridad;
using Servicios.Seguridad;
using Negocio.DefMatrizControl;
using Entidades.DefMatrizControl;

namespace Presentacion.DefMatrizControl
{
    public partial class FEvaluarMatrizControl : Form, IIdiomaObservador
    {
        NIdioma nIdioma = new NIdioma();
        Dictionary<string, string> diccionario;

        NMatrizControl nMatrizControl = new NMatrizControl();
        //NAreaNegocio nAreaNegocio = new NAreaNegocio();
        NRiesgoAceptado nRiesgo = new NRiesgoAceptado();
        NControlInternoPropuesto nControlInterno = new NControlInternoPropuesto();

        MatrizControl matrizControl;
        AreaNegocio areaNegocio;
        Riesgo riesgo;
        ControlInterno controlInterno;
        IList<EstadoMatrizControl> estadosMatrizControl;

        public FEvaluarMatrizControl()
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
                dataGridView1.DataSource = nMatrizControl.GetResumen(matrizControl);

                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void UpdGrillaRiesgos()
        {
            try
            {
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = nRiesgo.GetRiesgosAreaNegocio(matrizControl,areaNegocio);

                
                dataGridView2.Columns[2].Visible = false;
                dataGridView2.Columns[4].Visible = false;
                dataGridView2.Columns[5].Visible = false;
                dataGridView2.Columns[6].Visible = false;
                dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView2.MultiSelect = false;

                dataGridView3.DataSource = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void UpdGrillaControlesInternos()
        {
            try
            {
                dataGridView3.DataSource = null;

                if (radioButton1.Checked)
                {
                    dataGridView3.DataSource = nControlInterno.GetControlesInternos(riesgo);
                    
                }
                else if (radioButton2.Checked)
                {
                    dataGridView3.DataSource = (new NControlInternoObservado()).GetControlesInternos(riesgo);
                }
                else
                {
                    dataGridView3.DataSource = (new NControlInternoAceptado()).GetControlesInternos(riesgo);
                }

                dataGridView3.Columns[0].Visible = false;
                dataGridView3.Columns[5].Visible = false;
                dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView3.MultiSelect = false;
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
                SetearCombos();
                textBox1.Text = matrizControl.Id.ToString();
                textBox3.Text = matrizControl.Periodo.ToString();
                comboBox1.Text = matrizControl.Estado.ToString();
                UpdGrilla();
            }
            else
            {
                textBox1.Text = null;
                textBox3.Text = null;
                comboBox1.Text = null;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                dataGridView1.DataSource = null;
                dataGridView2.DataSource = null;
                dataGridView3.DataSource = null;
            }
            textBox2.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
        }

        private void SetearCombos()
        {
            // Estados
            comboBox1.Items.Clear();
            estadosMatrizControl = (new NEstadoMatrizControl()).GetEstados();

            foreach (var l in estadosMatrizControl)
            {
                comboBox1.Items.Add(l);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // verifica que no exista riesgo sin control
                if (nMatrizControl.RiesgosSinControl(matrizControl))
                {
                    throw new Exception(diccionario["msg_riesgo_sin_control"]);
                }

                // verifica que todos los controles estén aceptados
                if (nMatrizControl.ControlNoAceptado(matrizControl))
                {
                    throw new Exception(diccionario["msg_control_no_aceptado"]);
                }

                matrizControl.Estado = matrizControl.Estado = estadosMatrizControl.FirstOrDefault(x => x.Id == 3);

                nMatrizControl.ModificarMatrizControl(matrizControl);

                Inicializar();

                MessageBox.Show(diccionario["msg_matriz_aceptada"]);
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
                if (textBox2.Text == "")
                {
                    throw new Exception(diccionario["msg_observacion_null"]);
                }

                controlInterno.Observacion = textBox2.Text;

                nControlInterno.ObservarControlInterno((ControlInternoPropuesto)controlInterno);

                MessageBox.Show(diccionario["msg_control_observado"]);
                UpdGrillaControlesInternos();
                textBox2.Text = null;
                textBox4.Text = null;
                textBox5.Text = null;
                button2.Enabled = false;
                button3.Enabled = false;
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

                nControlInterno.AceptarControlInterno((ControlInternoPropuesto)controlInterno);

                MessageBox.Show("Control Interno Aceptado");
                UpdGrillaControlesInternos();
                textBox2.Text = null;
                textBox4.Text = null;
                textBox5.Text = null;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            areaNegocio = (AreaNegocio)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            UpdGrillaRiesgos();

            textBox2.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            riesgo = (RiesgoAceptado)dataGridView2.SelectedRows[0].DataBoundItem;
            UpdGrillaControlesInternos();

            textBox2.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            controlInterno = (ControlInterno)dataGridView3.SelectedRows[0].DataBoundItem;
            textBox2.Text = controlInterno.Observacion;
            textBox4.Text = controlInterno.Comentario;
            textBox5.Text = controlInterno.Nombre;

            if (radioButton1.Checked)
            {
                button2.Enabled = true;
                button3.Enabled = true;
            }
            else 
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdGrillaControlesInternos();
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdGrillaControlesInternos();
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            UpdGrillaControlesInternos();
            button2.Enabled = false;
            button3.Enabled = false;
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

        private void FEvaluarMatrizControl_Load(object sender, EventArgs e)
        {
            Sesion.Instancia.SuscribirObservador(this);
        }

        private void FEvaluarMatrizControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.Instancia.DesuscribirObservador(this);
        }

    }
}
