using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.MuiltiIdioma;
using Servicios.MultiIdioma;
using Negocio.MultiIdioma;
using Servicios.Seguridad;
using Servicios.GestionIntegridad;
using Negocio.Seguridad;
using Entidades.Seguridad;
using Entidades.GestionIntegridad;

namespace Presentacion
{
    public partial class FControlIntegridad : Form, IIdiomaObservador
    {
        NIdioma nIdioma = new NIdioma();
        Dictionary<string, string> diccionario;
        ControlIntegridad _ControlIntegridad = new ControlIntegridad();

        public FControlIntegridad()
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

                dataGridView1.DataSource = _ControlIntegridad.GetEntidades();
                dataGridView1.Columns[0].Visible = false;
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
            UpdGrilla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
      
            try
            {
                List<Integridad> datos = (new NUsuario()).Leer().ToList<Integridad>();

                foreach (var item in (new NUsuario()).Leer())
                {
                    (new NUsuario()).Operacion(item, 1);
                }
                UpdGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void FControlIntegridad_Load(object sender, EventArgs e)
        {
            Sesion.Instancia.SuscribirObservador(this);
        }

        private void FControlIntegridad_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.Instancia.DesuscribirObservador(this);
        }
    }
}
