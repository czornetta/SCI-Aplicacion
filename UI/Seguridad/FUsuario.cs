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
using Negocio.MultiIdioma;
using Servicios.MultiIdioma;
using Servicios.Seguridad;
using Entidades.Seguridad;
using Negocio.Seguridad;
using Entidades.GestionBitacora;
using Negocio.GestionBitacora;

namespace Presentacion
{
    public partial class FUsuario : Form, IIdiomaObservador
    {
        Dictionary<string, string> diccionario;

        private NUsuario negUsuario = new NUsuario();
        private Usuario usuario;
        NPrivilegio nPrivilegio = new NPrivilegio();
        List<Privilegio> lRoles;
        NAreaNegocio nAreaNegocio = new NAreaNegocio();

        NBitacora nBitacora = new NBitacora();
        Bitacora registro;

        public FUsuario()
        {
            InitializeComponent();
            ActualizarIdioma(Sesion.Instancia.Idioma);
            Inicializar();
        }

        public void RegistrarBitacora()
        {
            // registro en Bitacora
            registro.Fecha = DateTime.Now;
            registro.Usuario = Sesion.Instancia.Usuario;
            nBitacora.AgregarRegistro(registro);
        }

        private void UpdGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = negUsuario.Leer();
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void Inicializar()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;

            // Areas de Negocio
            comboBox2.Items.Clear();
            foreach (var l in nAreaNegocio.GetAreasNegocio())
            {
                comboBox2.Items.Add(l);
            }
            comboBox2.Text = null;

            UpdGrilla();

            treeView1.Nodes.Clear();
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void SetearComboPrivilegios()
        {
            // Combo Privilegios
            comboBox1.Items.Clear();

            foreach (var l in nPrivilegio.GetRoles())
            {
                Privilegio priv = lRoles.FirstOrDefault(x => x.Id == l.Id);

                if (priv == null)
                    comboBox1.Items.Add(l);
            }

            comboBox1.Text = null;
        }

        private void Asignar()
        {
            usuario.Nombre = textBox1.Text;
            usuario.AreaNegocio = (AreaNegocio)comboBox2.SelectedItem;

            if (textBox2.Text != textBox4.Text)
            {
                throw new Exception(diccionario["msg_contraseñas"]);
            }

            if (textBox3.Text != "")
            { 
                usuario.IdUsuario = Convert.ToInt16(textBox3.Text);

                if (!usuario.Clave.Equals(textBox2.Text))
                {
                    usuario.Clave = Cifrado.Cifrar(textBox2.Text);
                }
            }
            else
            {
                usuario.Clave = Cifrado.Cifrar(textBox2.Text);
            }
            
        }

        private void Operacion(int operacion)
        {
            try
            {
                Asignar();
                negUsuario.Operacion(usuario, operacion);
                
                Inicializar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //// verifica consistencia de clave
                //if (!textBox2.Text.Equals(textBox4.Text))
                //    throw new Exception("Error: Las contraseñas ingresadas deben ser iguales.");

                usuario = new Usuario();
                Operacion(0);
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
                //// verifica consistencia de clave
                //if (!textBox2.Text.Equals(textBox4.Text))
                //    throw new Exception("Error: Las contraseñas ingresadas deben ser iguales.");

                Operacion(1);
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
                if (textBox3.Text == "")
                    throw new Exception("No hay ningún usuario seleccionado.");

                Operacion(2);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            textBox1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            textBox2.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            textBox4.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            comboBox2.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);

            usuario = (Usuario)dataGridView1.SelectedRows[0].DataBoundItem;

            UpdTreeView();
        }

        void UpdTreeView()
        {
            // privilegios
            lRoles = nPrivilegio.GetPrivilegios(usuario);

            treeView1.Nodes.Clear();

            TreeNode root = new TreeNode(textBox1.Text);
            root.Tag = usuario;
            treeView1.Nodes.Add(root);

            foreach (var item in lRoles)
            {
                MostrarEnTreeView(root, item);
            }

            treeView1.ExpandAll();

            SetearComboPrivilegios();

            button4.Enabled = true;
            button5.Enabled = false;
        }

        void MostrarEnTreeView(TreeNode nodo, Privilegio priv)
        {
            TreeNode nNodo = new TreeNode(priv.Nombre);
            nodo.Tag = priv;
            nodo.Nodes.Add(nNodo);

            foreach (var item in priv.Privilegios)
            {
                MostrarEnTreeView(nNodo, item);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != "")
                {
                    Privilegio priv = (Privilegio)comboBox1.SelectedItem;

                    nPrivilegio.AgregarPrivilegioUsuario(usuario, priv);

                    UpdTreeView();
                }
                else
                {
                    MessageBox.Show(diccionario["msg_seleccionar_privilegio"]);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                Privilegio priv = lRoles.FirstOrDefault(x => x.Nombre.Equals(treeView1.SelectedNode.Text));

                lRoles.Remove(priv);
                nPrivilegio.BorrarPrivilegioUsuario(usuario, priv);

                UpdTreeView();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Privilegio priv = lRoles.FirstOrDefault(x => x.Nombre.Equals(treeView1.SelectedNode.Text));

            if (priv != null)
            {
                // MessageBox.Show("privilegio: " + priv.Nombre);

                button5.Enabled = true;
            }
            else
            {
                button5.Enabled = false;
            }
        }

        public void ActualizarIdioma(Idioma idioma)
        {

            diccionario = (new NIdioma()).GetDiccionario(idioma);

            try
            {
                label1.Text = diccionario[label1.Tag.ToString()];
                label2.Text = diccionario[label2.Tag.ToString()];
                label4.Text = diccionario[label4.Tag.ToString()];
                label5.Text = diccionario[label5.Tag.ToString()];
                groupBox1.Text = diccionario[groupBox1.Tag.ToString()];

                button1.Text = diccionario[button1.Tag.ToString()];
                button2.Text = diccionario[button2.Tag.ToString()];
                button3.Text = diccionario[button3.Tag.ToString()];
                button4.Text = diccionario[button4.Tag.ToString()];
                button5.Text = diccionario[button5.Tag.ToString()];

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FUsuario_Load(object sender, EventArgs e)
        {
            Sesion.Instancia.SuscribirObservador(this);
        }

        private void FUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.Instancia.DesuscribirObservador(this);
        }
    }
}
