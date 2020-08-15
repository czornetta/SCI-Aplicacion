using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios.Seguridad;
using Entidades.DefMatrizControl;

namespace Presentacion.Pruebas
{
    public partial class FPrueba1 : Form
    {
        public FPrueba1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Cifrado.Encriptar(textBox1.Text);
            textBox3.Text = Cifrado.Desencriptar(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;

        }
    }
}
