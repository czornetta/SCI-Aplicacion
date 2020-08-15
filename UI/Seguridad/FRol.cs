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
    public partial class FRol : Form, IIdiomaObservador
    {
        Dictionary<string, string> diccionario;
        NPrivilegio nPrivilegio = new NPrivilegio();
        List<Privilegio> lPrivilegios;
        Rol rol;

        public FRol()
        {
            InitializeComponent();
            ActualizarIdioma(Sesion.Instancia.Idioma);
            Inicializar();
        }

        private void UpdGrilla()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = nPrivilegio.GetPrivilegios();
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void Inicializar()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            treeView1.Nodes.Clear();
            
            //lRoles = nPrivilegio.GetPrivilegios();
            UpdGrilla();

            SetearComboPrivilegios();

            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void SetearComboPrivilegios()
        {
            // Combo Privilegios
            comboBox1.Items.Clear();

            if (radioButton1.Checked)
            {
                lPrivilegios = nPrivilegio.GetRoles();

                foreach (var l in nPrivilegio.GetPrivilegios())
                {
                    if (rol != null)
                    {
                        if (rol.Id != l.Id)
                        {
                            if (!nPrivilegio.EsPrivilegioPadre(l, rol))
                            {
                                Privilegio priv = rol.Privilegios.FirstOrDefault(x => x.Id == l.Id);

                                if (priv == null)
                                    comboBox1.Items.Add(l);
                            }
                        }
                    }
                    else
                        comboBox1.Items.Add(l);

                }
            }
            else
            {
                lPrivilegios = nPrivilegio.GetPermisos();

                foreach (var l in lPrivilegios)
                {
                    if (rol != null)
                    {
                        Privilegio priv = rol.Privilegios.FirstOrDefault(x => x.Id == l.Id);

                       if (priv == null)
                           comboBox1.Items.Add(l);
                    }
                    else
                        comboBox1.Items.Add(l);
                }
            }

            comboBox1.Text = null;
        }

        private void Asignar()
        {
            if (textBox1.Text != "")
            {
                rol.Id = Convert.ToInt16(textBox1.Text);
            }
            rol.Nombre = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                rol = new Rol();
                Asignar();
                nPrivilegio.AgregarPrivilegio(rol);

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
                //rol = new Rol();
                Asignar();
                nPrivilegio.ModificarPrivilegio(rol);

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
                //rol = new Rol();
                Asignar();
                nPrivilegio.BorrarPrivilegio(rol);

                Inicializar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            textBox2.Text = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);

            rol = (Rol)dataGridView1.SelectedRows[0].DataBoundItem;

            treeView1.Nodes.Clear();

            TreeNode root = new TreeNode(textBox2.Text);
            root.Tag = rol;
            treeView1.Nodes.Add(root);

            foreach (var item in rol.Privilegios)
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

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            Privilegio priv = rol.BuscarPrivilegio(treeView1.SelectedNode.Text);

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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text != "")
                {
                    Privilegio priv = (Privilegio)comboBox1.SelectedItem;

                    if (radioButton1.Checked)
                    {
                        priv = nPrivilegio.GetPrivilegios().Find(u => u.Id == priv.Id);
                    }

                    rol.AgregarPrivilegio(priv);
                    nPrivilegio.AgregarPrivilegioHijo(rol, priv);

                    // Actualizo el arbol
                    treeView1.Nodes.Clear();

                    TreeNode root = new TreeNode(textBox2.Text);
                    root.Tag = rol;
                    treeView1.Nodes.Add(root);

                    foreach (var item in rol.Privilegios)
                    {
                        MostrarEnTreeView(root, item);
                    }

                    treeView1.ExpandAll();

                    SetearComboPrivilegios();

                    var rolSeleccionado = dataGridView1.SelectedRows[0].Index;

                    UpdGrilla();

                    dataGridView1.Rows[rolSeleccionado].Selected = true;
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
                
                Privilegio priv = rol.BuscarPrivilegio(treeView1.SelectedNode.Text);

                rol.BorrarPrivilegio(priv);
                nPrivilegio.BorrarPrivilegioHijo(rol, priv);

                // Actualizo el arbol
                treeView1.Nodes.Clear();

                TreeNode root = new TreeNode(textBox2.Text);
                root.Tag = rol;
                treeView1.Nodes.Add(root);

                foreach (var item in rol.Privilegios)
                {
                    MostrarEnTreeView(root, item);
                }

                treeView1.ExpandAll();

                SetearComboPrivilegios();

                var rolSeleccionado = dataGridView1.SelectedRows[0].Index;

                UpdGrilla();

                dataGridView1.Rows[rolSeleccionado].Selected = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SetearComboPrivilegios();
        }

        public void ActualizarIdioma(Idioma idioma)
        {

            diccionario = (new NIdioma()).GetDiccionario(idioma);

            try
            {
                label2.Text = diccionario[label2.Tag.ToString()];
                label3.Text = diccionario[label3.Tag.ToString()];
                radioButton1.Text = diccionario[radioButton1.Tag.ToString()];
                radioButton2.Text = diccionario[radioButton2.Tag.ToString()];

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

        private void FRol_Load(object sender, EventArgs e)
        {
            Sesion.Instancia.SuscribirObservador(this);
        }

        private void FRol_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.Instancia.DesuscribirObservador(this);
        }
    }
}
