using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Seguridad;
using Negocio.Seguridad;
using Servicios.Seguridad;
using Negocio.MultiIdioma;
using Entidades.MuiltiIdioma;
using Servicios.MultiIdioma;

namespace Presentacion.Seguridad
{
    public partial class FPermiso : Form, IIdiomaObservador
    {
        NPrivilegio nPrivilegio = new NPrivilegio();
        List<Privilegio> lPermisos;
        Permiso permiso;
       
        public FPermiso()
        {
            InitializeComponent();
            ActualizarIdioma(Sesion.Instancia.Idioma);
            Inicializar();
        }

        private void UpdGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lPermisos;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void Inicializar()
        {
            textBox1.Text = null;
            textBox2.Text = null;

            lPermisos = nPrivilegio.GetPermisos();
            comboBox1.Items.Clear();
                        
            foreach (var l in Enum.GetValues(typeof(Llave)))
            {
                if (!lPermisos.Exists(x => x.Llave == (Llave)l))
                    comboBox1.Items.Add(l);
            }

            comboBox1.Text = null;

            UpdGrilla();

        }

        private void Asignar()
        {
            if (textBox1.Text != "")
            {
                permiso.Id = Convert.ToInt16(textBox1.Text);
            }
            permiso.Nombre = textBox2.Text;
            permiso.Llave = (Llave)Enum.Parse(typeof(Llave),comboBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                permiso = new Permiso();
                Asignar();
                nPrivilegio.AgregarPrivilegio(permiso);
                
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
                permiso = new Permiso();
                Asignar();
                nPrivilegio.ModificarPrivilegio(permiso);

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
                permiso = new Permiso();
                Asignar();
                nPrivilegio.BorrarPrivilegio(permiso);

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
                textBox2.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                comboBox1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            }
        }

        public void ActualizarIdioma(Idioma idioma)
        {

            Dictionary<string, string> diccionario = (new NIdioma()).GetDiccionario(idioma);

            try
            {
                label2.Text = diccionario[label2.Tag.ToString()];
                label3.Text = diccionario[label3.Tag.ToString()];
                button1.Text = diccionario[button1.Tag.ToString()];
                button2.Text = diccionario[button2.Tag.ToString()];
                button3.Text = diccionario[button3.Tag.ToString()];

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FPermiso_Load(object sender, EventArgs e)
        {
            Sesion.Instancia.SuscribirObservador(this);
        }

        private void FPermiso_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.Instancia.DesuscribirObservador(this);
        }
    }
}
