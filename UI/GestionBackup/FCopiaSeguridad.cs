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
using Entidades.Seguridad;
using Servicios.Seguridad;
using Entidades.MuiltiIdioma;
using Servicios.MultiIdioma;
using Servicios.GestionBackup;

namespace Presentacion.GestionBackup
{
    public partial class FCopiaSeguridad : Form, IIdiomaObservador
    {
        NIdioma nIdioma = new NIdioma();
        Dictionary<string, string> diccionario;
        NBackup nBackup = new NBackup();
        Backup backup;

        public FCopiaSeguridad()
        {
            InitializeComponent();
            ActualizarIdioma(Sesion.Instancia.Idioma);
            UpdGrilla();
        }

        private void UpdGrilla()
        {
            try
            {
                dataGridView1.DataSource = null;

                dataGridView1.DataSource = nBackup.LeerBackups(backup);
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].Width = 350;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                nBackup.CopiarBD();
                this.Cursor = Cursors.Default;
                MessageBox.Show(diccionario["msg_copia_seguridad"]);
                UpdGrilla();
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (backup !=null)
                {
                    if (MessageBox.Show(diccionario["msg_confirmar_restauracion"] + backup.Fecha.ToString(), "SCI",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        nBackup.RestaurarBD(backup);
                        this.Cursor = Cursors.Default;
                        backup = null;
                        MessageBox.Show(diccionario["msg_copia_restaurada"]);
                        UpdGrilla();
                        
                    }
                }
                else
                {
                    
                    MessageBox.Show(diccionario["msg_seleccionar_bkp"]);
                }
                
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            backup = (Backup)dataGridView1.SelectedRows[0].DataBoundItem;
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

        private void FCopiaSeguridad_Load(object sender, EventArgs e)
        {
            Sesion.Instancia.SuscribirObservador(this);
        }

        private void FCopiaSeguridad_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.Instancia.DesuscribirObservador(this);
        }
    }
}
