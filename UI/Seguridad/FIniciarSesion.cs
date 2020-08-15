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
using Servicios.MultiIdioma;
using Entidades.MuiltiIdioma;
using Negocio.MultiIdioma;

namespace Presentacion
{
    public partial class FIniciarSesion : Form, IIdiomaObservador
    {
        Dictionary<string, string> diccionario;

        NUsuario _NUsuario = new NUsuario();
        NIdioma nIdioma = new NIdioma();
        Idioma idioma;

        public FIniciarSesion()
        {
            InitializeComponent();

            if (Sesion.SesionActiva())
            {
                idioma = Sesion.Instancia.Idioma;
            }
            else
            {
                idioma = nIdioma.GetIdiomaPrincipal();
            }

            ActualizarIdioma(idioma);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tBNombre.Text =="" || tBClave.Text == "")
                    throw new Exception(diccionario["msg_usuario_clave"]);

                LoginResult resultado = _NUsuario.IniciarSesion(tBNombre.Text, tBClave.Text);

                if (resultado == LoginResult.ValidUser)
                {
                    ((Form1)this.MdiParent).SetearMenu();
                    this.Close();
                }
                    

            }
            catch (LoginException ex)
            {
                switch (ex.Result)
                {
                    case LoginResult.ExistsActiveSesion:
                        MessageBox.Show(diccionario["msg_sesion_activa"]);
                        break;
                    case LoginResult.InvalidUsername:
                        MessageBox.Show(diccionario["msg_usuario_no_registrado"]);
                        break;
                    case LoginResult.InvalidPassword:
                        MessageBox.Show(diccionario["msg_clave_incorrecta"]);
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
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
                label1.Text = diccionario[label1.Tag.ToString()];
                label2.Text = diccionario[label2.Tag.ToString()];
                btnIniciar.Text = diccionario[btnIniciar.Tag.ToString()];
                btnCancelar.Text = diccionario[btnCancelar.Tag.ToString()];

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
