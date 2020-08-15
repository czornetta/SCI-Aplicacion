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
using Servicios.Seguridad;
using Entidades.MuiltiIdioma;
using Servicios.MultiIdioma;

namespace Presentacion.MultiIdioma
{
    public partial class FCambiarIdioma : Form, IIdiomaObservador
    {
        NIdioma nIdioma = new NIdioma();
        Idioma idioma;

        public FCambiarIdioma()
        {
            InitializeComponent();
            
            SetearComboIdiomas();
            ActualizarIdioma(Sesion.Instancia.Idioma);
        }

        private void SetearComboIdiomas()
        {
            comboBox1.Items.Clear();

            foreach (var l in nIdioma.GetIdiomas())
            {
                comboBox1.Items.Add(l);
            }

            comboBox1.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                idioma = (Idioma)comboBox1.SelectedItem;

                if (Sesion.SesionActiva())
                {
                    
                    Sesion.Instancia.Idioma = idioma;
                    
                }
                
            }
        }

        public void ActualizarIdioma(Idioma idioma)
        {

            Dictionary<string, string> diccionario = nIdioma.GetDiccionario(idioma);

            try
            {
                label1.Text = diccionario[label1.Tag.ToString()];
                button1.Text = diccionario[button1.Tag.ToString()];

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FCambiarIdioma_Load(object sender, EventArgs e)
        {
            Sesion.Instancia.SuscribirObservador(this);
        }

        private void FCambiarIdioma_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.Instancia.DesuscribirObservador(this);
        }
        
    }
}
