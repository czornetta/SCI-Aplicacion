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
        public FBaseDeDatos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TextReader sqlFile = new StreamReader("ScriptBASE.sql");
                string sql = sqlFile.ReadToEnd();
                
                (new Repositorio()).CrearBD(sql);

                MessageBox.Show("Base creada correctamente");

                sqlFile = new StreamReader("ScriptBASEPRUEBA1.sql");
                sql = sqlFile.ReadToEnd();

                (new Repositorio()).CrearBD(sql);

                MessageBox.Show("Tablas y procesos creados");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
