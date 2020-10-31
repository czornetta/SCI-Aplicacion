using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Servicios.GestionBackup;

namespace Presentacion.GestionBackup
{
    public partial class FBaseDeDatos : Form
    {
        InstanciaBD InstanciaBD = new InstanciaBD();
        NInstanciaBD nInstanciaBD = new NInstanciaBD();

        public FBaseDeDatos()
        {
            InitializeComponent();
            Inicializar();
        }

        public void Inicializar()
        {
            comboBox1.DataSource = nInstanciaBD.GetInstancias();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            try
            {
                if (comboBox1.SelectedItem == null)
                {
                    throw new Exception("Debe seleccionar una Instancia de Base de datos");
                }

                this.Cursor = Cursors.WaitCursor;

                InstanciaBD.Nombre = comboBox1.SelectedItem.ToString();

                nInstanciaBD.CrearBD();

                this.Cursor = Cursors.Default;

                MessageBox.Show("Base creada correctamente");

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FBaseDeDatos_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!(InstanciaBD.EstadoBD))
            {
                MessageBox.Show("No se ha creado la base datos para la aplicación. La Aplicación de Cerrará.");
                
                Application.Exit();

            }
        }
    }
}
