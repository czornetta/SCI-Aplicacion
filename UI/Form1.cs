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
using Presentacion.Seguridad;
using Presentacion.MultiIdioma;
using Presentacion.Pruebas;
using Entidades.MuiltiIdioma;
using Negocio.MultiIdioma;
using Servicios.MultiIdioma;
using Presentacion.DefMatrizControl;
using Presentacion.GestionBitacora;

namespace Presentacion
{
    public partial class Form1 : Form, IIdiomaObservador
    {
        NIdioma nIdioma = new NIdioma();
        Idioma idioma;
        Dictionary<string, string> diccionario;

        public Form1()
        {
            InitializeComponent();

            Diccionario();
            Traducir();
            // Login Usuario Leo
            LoginResult resultado = (new NUsuario()).IniciarSesion("leo", "123");

            SetearMenu();
        }

        public void Diccionario()
        {
            if (Sesion.SesionActiva())
            {
                idioma = Sesion.Instancia.Idioma;
            }
            else
            {
                idioma = nIdioma.GetIdiomaPrincipal();
            }
            diccionario = nIdioma.GetDiccionario(idioma);

        }

        public void Traducir()
        {
            try
            {
                //MessageBox.Show(iniciarSesiónToolStripMenuItem.Tag.ToString());
                //Submenu
                sesiónToolStripMenuItem.Text = diccionario[sesiónToolStripMenuItem.Tag.ToString()];
                matrizDeControlToolStripMenuItem.Text = diccionario[matrizDeControlToolStripMenuItem.Tag.ToString()];
                seguridadToolStripMenuItem.Text = diccionario[seguridadToolStripMenuItem.Tag.ToString()];
                idiomaToolStripMenuItem.Text = diccionario[idiomaToolStripMenuItem.Tag.ToString()];
                pruebasToolStripMenuItem.Text = diccionario[pruebasToolStripMenuItem.Tag.ToString()];

                //Sesion
                iniciarSesiónToolStripMenuItem.Text = diccionario[iniciarSesiónToolStripMenuItem.Tag.ToString()];
                cerrarSesiónToolStripMenuItem.Text = diccionario[cerrarSesiónToolStripMenuItem.Tag.ToString()];

                //Matriz de Control
                periodoDeControlToolStripMenuItem.Text = diccionario[periodoDeControlToolStripMenuItem.Tag.ToString()];
                riesgosToolStripMenuItem.Text = diccionario[riesgosToolStripMenuItem.Tag.ToString()];
                evaluarRiesgosToolStripMenuItem.Text = diccionario[evaluarRiesgosToolStripMenuItem.Tag.ToString()];
                riesgosObservadosToolStripMenuItem.Text = diccionario[riesgosObservadosToolStripMenuItem.Tag.ToString()];
                finalizarRelevamientoToolStripMenuItem.Text = diccionario[finalizarRelevamientoToolStripMenuItem.Tag.ToString()];
                definirControlesInternosToolStripMenuItem.Text = diccionario[definirControlesInternosToolStripMenuItem.Tag.ToString()];
                evaluarMatrizDeControlToolStripMenuItem.Text = diccionario[evaluarMatrizDeControlToolStripMenuItem.Tag.ToString()];
                controlesObservadosToolStripMenuItem.Text = diccionario[controlesObservadosToolStripMenuItem.Tag.ToString()];
                matrizDeControlActivaToolStripMenuItem.Text = diccionario[matrizDeControlActivaToolStripMenuItem.Tag.ToString()];

                //Seguridad
                areasDeNegocioToolStripMenuItem.Text = diccionario[areasDeNegocioToolStripMenuItem.Tag.ToString()];
                usuariosToolStripMenuItem.Text = diccionario[usuariosToolStripMenuItem.Tag.ToString()];
                privilegiosToolStripMenuItem.Text = diccionario[privilegiosToolStripMenuItem.Tag.ToString()];
                rolesToolStripMenuItem.Text = diccionario[rolesToolStripMenuItem.Tag.ToString()];
                bitacoraToolStripMenuItem.Text = diccionario[bitacoraToolStripMenuItem.Tag.ToString()];

                //Idiomas
                idiomaToolStripMenuItem1.Text = diccionario[idiomaToolStripMenuItem1.Tag.ToString()];
                etiquetasToolStripMenuItem.Text = diccionario[etiquetasToolStripMenuItem.Tag.ToString()];
                traduccionesToolStripMenuItem.Text = diccionario[traduccionesToolStripMenuItem.Tag.ToString()];
                cambiarIdiomaToolStripMenuItem.Text = diccionario[cambiarIdiomaToolStripMenuItem.Tag.ToString()];
                
                //Pruebas
                pruebaToolStripMenuItem.Text = diccionario[pruebaToolStripMenuItem.Tag.ToString()];
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        public void SetearMenu()
        { 
            // Menu
            this.seguridadToolStripMenuItem.Enabled = Sesion.SesionActiva();
            this.idiomaToolStripMenuItem.Enabled = Sesion.SesionActiva();
            this.pruebasToolStripMenuItem.Enabled = Sesion.SesionActiva();
            this.matrizDeControlToolStripMenuItem.Enabled = Sesion.SesionActiva();

            //Sesion
            this.iniciarSesiónToolStripMenuItem.Enabled = !Sesion.SesionActiva();
            this.cerrarSesiónToolStripMenuItem.Enabled = Sesion.SesionActiva();
            this.cambiarIdiomaToolStripMenuItem.Enabled = Sesion.SesionActiva();
            

            // Control de llaves
            if (Sesion.SesionActiva())
            {
                //Matriz de Control
                this.periodoDeControlToolStripMenuItem.Enabled = Sesion.Instancia.TieneLlave(Llave.FMatrizControlInterno);
                this.riesgosToolStripMenuItem.Enabled = Sesion.Instancia.TieneLlave(Llave.FRiesgo);
                this.evaluarRiesgosToolStripMenuItem.Enabled = Sesion.Instancia.TieneLlave(Llave.FEvaluarRiesgo);
                this.riesgosObservadosToolStripMenuItem.Enabled = Sesion.Instancia.TieneLlave(Llave.FRiesgosObservados);
                this.finalizarRelevamientoToolStripMenuItem.Enabled = Sesion.Instancia.TieneLlave(Llave.FFinalizarRelevamiento);
                this.definirControlesInternosToolStripMenuItem.Enabled = Sesion.Instancia.TieneLlave(Llave.FControlInterno);
                this.evaluarMatrizDeControlToolStripMenuItem.Enabled = Sesion.Instancia.TieneLlave(Llave.FEvaluarMatrizControl);
                this.controlesObservadosToolStripMenuItem.Enabled = Sesion.Instancia.TieneLlave(Llave.FControlesObservados);
                this.matrizDeControlActivaToolStripMenuItem.Enabled = Sesion.Instancia.TieneLlave(Llave.FMatrizControlInternoVigente);

                //Seguridad
                this.areasDeNegocioToolStripMenuItem.Enabled = Sesion.Instancia.TieneLlave(Llave.FAreaNegocio);
                this.usuariosToolStripMenuItem.Enabled = Sesion.Instancia.TieneLlave(Llave.FUsuario);
                this.privilegiosToolStripMenuItem.Enabled = Sesion.Instancia.TieneLlave(Llave.FPermiso);
                this.rolesToolStripMenuItem.Enabled = Sesion.Instancia.TieneLlave(Llave.FRol);
                this.bitacoraToolStripMenuItem.Enabled = Sesion.Instancia.TieneLlave(Llave.FBitacora);

                // Idiomas
                this.idiomaToolStripMenuItem1.Enabled = Sesion.Instancia.TieneLlave(Llave.FIdioma);
                this.etiquetasToolStripMenuItem.Enabled = Sesion.Instancia.TieneLlave(Llave.FEtiqueta);
                this.traduccionesToolStripMenuItem.Enabled = Sesion.Instancia.TieneLlave(Llave.FTraduccion);
                this.cambiarIdiomaToolStripMenuItem.Enabled = Sesion.Instancia.TieneLlave(Llave.FCambiarIdioma);

                // Pruebas
                this.pruebaToolStripMenuItem.Enabled = Sesion.Instancia.TieneLlave(Llave.FPrueba1);
            }
            else
            {
                //Seguridad
                this.areasDeNegocioToolStripMenuItem.Enabled = false;
                this.usuariosToolStripMenuItem.Enabled = false;
                this.privilegiosToolStripMenuItem.Enabled = false;
                this.rolesToolStripMenuItem.Enabled = false;
                this.bitacoraToolStripMenuItem.Enabled = false;

                // Idiomas
                this.idiomaToolStripMenuItem.Enabled = false;
                this.etiquetasToolStripMenuItem.Enabled = false;
                this.traduccionesToolStripMenuItem.Enabled = false;
                this.cambiarIdiomaToolStripMenuItem.Enabled = false;
                

                // Pruebas
                this.pruebaToolStripMenuItem.Enabled = false;
            }
        }

        public bool FormAbierto(string nombreForm)
        {
            Form formActivo = new Form();
            bool formAbierto = false;

            var formularios = Application.OpenForms;

            foreach (Form f in formularios)
            {
                if (f.Name == nombreForm)
                {
                    formAbierto = true;
                    f.Focus();
                }
                else if (f.Name != "Form1")
                    formActivo = f;
            }

            formActivo.Close();

            return formAbierto;
        }

        #region Menu Sesion
        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAbierto("FIniciarSesion"))
            {
                FIniciarSesion f = new FIniciarSesion();
                f.MdiParent = this;
                f.Text = diccionario[iniciarSesiónToolStripMenuItem.Tag.ToString()];
                f.Show();
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Sesion.SesionActiva())
                    throw new Exception("No hay sesión iniciada");

                if (MessageBox.Show(Sesion.Instancia.Usuario.ToString() + diccionario["msg_cerrar_sesion"], "Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bool formAbierto = FormAbierto("");
                    (new NUsuario()).CerrarSesion();
                    SetearMenu();
                    //this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Menu Seguridad
        private void areasDeNegocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAbierto("FAreaNegocio"))
            {
                FAreaNegocio f = new FAreaNegocio();
                f.MdiParent = this;
                f.Text = diccionario[areasDeNegocioToolStripMenuItem.Tag.ToString()];
                f.Show();
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAbierto("FUsuario"))
            {
                FUsuario f = new FUsuario();
                f.MdiParent = this;
                f.Text = diccionario[usuariosToolStripMenuItem.Tag.ToString()];
                f.Show();
            }
        }

        private void privilegiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAbierto("FPermiso"))
            {
                FPermiso f = new FPermiso();
                f.MdiParent = this;
                f.Text = diccionario[privilegiosToolStripMenuItem.Tag.ToString()];
                f.Show();
            }
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAbierto("FRol"))
            {
                FRol f = new FRol();
                f.MdiParent = this;
                f.Text = diccionario[rolesToolStripMenuItem.Tag.ToString()];
                f.Show();
            }
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAbierto("FBitacora"))
            {
                FBitacora f = new FBitacora();
                f.MdiParent = this;
                f.Text = diccionario[bitacoraToolStripMenuItem.Tag.ToString()];
                f.Show();
            }
        }
        #endregion

        #region Idiomas
        private void idiomaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!FormAbierto("FIdioma"))
            {
                FIdioma f = new FIdioma();
                f.MdiParent = this;
                f.Text = diccionario[idiomaToolStripMenuItem.Tag.ToString()];
                f.Show();
            }
        }

        private void etiquetasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAbierto("FEtiqueta"))
            {
                FEtiqueta f = new FEtiqueta();
                f.MdiParent = this;
                f.Text = diccionario[etiquetasToolStripMenuItem.Tag.ToString()];
                f.Show();
            }
        }

        private void traduccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAbierto("FTraduccion"))
            {
                FTraduccion f = new FTraduccion();
                f.MdiParent = this;
                f.Text = diccionario[traduccionesToolStripMenuItem.Tag.ToString()];
                f.Show();
            }
        }

        private void cambiarIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAbierto("FCambiarIdioma"))
            {
                FCambiarIdioma f = new FCambiarIdioma();
                f.MdiParent = this;
                f.Show();
            }
        }
        #endregion

        #region Matriz de Control
        private void periodoDeControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAbierto("FMatrizControlInterno"))
            {
                FMatrizControlInterno f = new FMatrizControlInterno();
                f.MdiParent = this;
                f.Text = diccionario[periodoDeControlToolStripMenuItem.Tag.ToString()];
                f.Show();
            }
        }

        private void riesgosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAbierto("FRiesgo"))
            {
                FRiesgo f = new FRiesgo();
                f.MdiParent = this;
                f.Text = diccionario[riesgosToolStripMenuItem.Tag.ToString()];
                f.Show();
            }
        }

        private void evaluarRiesgosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAbierto("FEvaluarRiesgo"))
            {
                FEvaluarRiesgo f = new FEvaluarRiesgo();
                f.MdiParent = this;
                f.Text = diccionario[evaluarRiesgosToolStripMenuItem.Tag.ToString()];
                f.Show();
            }
            
        }

        private void riesgosObservadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (!FormAbierto("FRiesgosObservados"))
            {
                FRiesgosObservados f = new FRiesgosObservados();
                f.MdiParent = this;
                f.Text = diccionario[riesgosObservadosToolStripMenuItem.Tag.ToString()];
                f.Show();
            }
        }

        private void finalizarRelevamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAbierto("FFinalizarRelevamiento"))
            {
                FFinalizarRelevamiento f = new FFinalizarRelevamiento();
                f.MdiParent = this;
                f.Text = diccionario[finalizarRelevamientoToolStripMenuItem.Tag.ToString()];
                f.Show();
            }
        }

        private void definirControlesInternosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAbierto("FControlInterno"))
            {
                FControlInterno f = new FControlInterno();
                f.MdiParent = this;
                f.Text = diccionario[definirControlesInternosToolStripMenuItem.Tag.ToString()];
                f.Show();
            }
        }


        private void evaluarMatrizDeControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAbierto("FEvaluarMatrizControl"))
            {
                FEvaluarMatrizControl f = new FEvaluarMatrizControl();
                f.MdiParent = this;
                f.Text = diccionario[evaluarMatrizDeControlToolStripMenuItem.Tag.ToString()];
                f.Show();
            }
        }

        private void controlesObservadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAbierto("FControlesObservados"))
            {
                FControlesObservados f = new FControlesObservados();
                f.MdiParent = this;
                f.Text = diccionario[controlesObservadosToolStripMenuItem.Tag.ToString()];
                f.Show();
            }
        }

        private void matrizDeControlActivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAbierto("FMatrizControlInternoVigente"))
            {
                FMatrizControlInternoVigente f = new FMatrizControlInternoVigente();
                f.MdiParent = this;
                f.Text = diccionario[matrizDeControlActivaToolStripMenuItem.Tag.ToString()];
                f.Show();
            }
        }

        #endregion

        private void pruebaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!FormAbierto("FPrueba1"))
            {
                FPrueba1 f = new FPrueba1();
                f.MdiParent = this;
                f.Text = diccionario[pruebaToolStripMenuItem.Tag.ToString()];
                f.Show();
            }
        }

        public void ActualizarIdioma(Idioma idioma)
        {
            Dictionary<string, string> diccionario = nIdioma.GetDiccionario(idioma);

            try
            {
                Diccionario();
                Traducir();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sesion.Instancia.SuscribirObservador(this);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sesion.Instancia.DesuscribirObservador(this);
        }

    }
}
