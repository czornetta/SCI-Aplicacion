namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrizDeControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodoDeControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riesgosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluarRiesgosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riesgosObservadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarRelevamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.definirControlesInternosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluarMatrizDeControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlesObservadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrizDeControlActivaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlInternoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.certificarControlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluarExcepcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeDeResultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areasDeNegocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privilegiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.etiquetasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traduccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarIdiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pruebasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pruebaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiaDeSeguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlDeIntegridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoriaRiesgosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesiónToolStripMenuItem,
            this.matrizDeControlToolStripMenuItem,
            this.controlInternoToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.idiomaToolStripMenuItem,
            this.pruebasToolStripMenuItem,
            this.administracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sesiónToolStripMenuItem
            // 
            this.sesiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesiónToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.sesiónToolStripMenuItem.Enabled = false;
            this.sesiónToolStripMenuItem.Name = "sesiónToolStripMenuItem";
            this.sesiónToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sesiónToolStripMenuItem.Tag = "menu_sesion";
            this.sesiónToolStripMenuItem.Text = "Sesión";
            // 
            // iniciarSesiónToolStripMenuItem
            // 
            this.iniciarSesiónToolStripMenuItem.Name = "iniciarSesiónToolStripMenuItem";
            this.iniciarSesiónToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.iniciarSesiónToolStripMenuItem.Tag = "iniciar_sesion";
            this.iniciarSesiónToolStripMenuItem.Text = "Iniciar Sesión";
            this.iniciarSesiónToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesiónToolStripMenuItem_Click);
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesiónToolStripMenuItem.Tag = "cerrar_sesion";
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // matrizDeControlToolStripMenuItem
            // 
            this.matrizDeControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.periodoDeControlToolStripMenuItem,
            this.riesgosToolStripMenuItem,
            this.evaluarRiesgosToolStripMenuItem,
            this.riesgosObservadosToolStripMenuItem,
            this.finalizarRelevamientoToolStripMenuItem,
            this.definirControlesInternosToolStripMenuItem,
            this.evaluarMatrizDeControlToolStripMenuItem,
            this.controlesObservadosToolStripMenuItem,
            this.matrizDeControlActivaToolStripMenuItem});
            this.matrizDeControlToolStripMenuItem.Enabled = false;
            this.matrizDeControlToolStripMenuItem.Name = "matrizDeControlToolStripMenuItem";
            this.matrizDeControlToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.matrizDeControlToolStripMenuItem.Tag = "menu_matrizControl";
            this.matrizDeControlToolStripMenuItem.Text = "Matriz de Control";
            // 
            // periodoDeControlToolStripMenuItem
            // 
            this.periodoDeControlToolStripMenuItem.Name = "periodoDeControlToolStripMenuItem";
            this.periodoDeControlToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.periodoDeControlToolStripMenuItem.Tag = "periodo_control";
            this.periodoDeControlToolStripMenuItem.Text = "Periodo de Control";
            this.periodoDeControlToolStripMenuItem.Click += new System.EventHandler(this.periodoDeControlToolStripMenuItem_Click);
            // 
            // riesgosToolStripMenuItem
            // 
            this.riesgosToolStripMenuItem.Name = "riesgosToolStripMenuItem";
            this.riesgosToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.riesgosToolStripMenuItem.Tag = "riesgos";
            this.riesgosToolStripMenuItem.Text = "Riesgos";
            this.riesgosToolStripMenuItem.Click += new System.EventHandler(this.riesgosToolStripMenuItem_Click);
            // 
            // evaluarRiesgosToolStripMenuItem
            // 
            this.evaluarRiesgosToolStripMenuItem.Name = "evaluarRiesgosToolStripMenuItem";
            this.evaluarRiesgosToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.evaluarRiesgosToolStripMenuItem.Tag = "evaluar_riesgos";
            this.evaluarRiesgosToolStripMenuItem.Text = "Evaluar Riesgos";
            this.evaluarRiesgosToolStripMenuItem.Click += new System.EventHandler(this.evaluarRiesgosToolStripMenuItem_Click);
            // 
            // riesgosObservadosToolStripMenuItem
            // 
            this.riesgosObservadosToolStripMenuItem.Name = "riesgosObservadosToolStripMenuItem";
            this.riesgosObservadosToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.riesgosObservadosToolStripMenuItem.Tag = "riesgosObservados";
            this.riesgosObservadosToolStripMenuItem.Text = "Riesgos Observados";
            this.riesgosObservadosToolStripMenuItem.Click += new System.EventHandler(this.riesgosObservadosToolStripMenuItem_Click);
            // 
            // finalizarRelevamientoToolStripMenuItem
            // 
            this.finalizarRelevamientoToolStripMenuItem.Name = "finalizarRelevamientoToolStripMenuItem";
            this.finalizarRelevamientoToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.finalizarRelevamientoToolStripMenuItem.Tag = "finalizar_relevamiento";
            this.finalizarRelevamientoToolStripMenuItem.Text = "Finalizar Relevamiento";
            this.finalizarRelevamientoToolStripMenuItem.Click += new System.EventHandler(this.finalizarRelevamientoToolStripMenuItem_Click);
            // 
            // definirControlesInternosToolStripMenuItem
            // 
            this.definirControlesInternosToolStripMenuItem.Name = "definirControlesInternosToolStripMenuItem";
            this.definirControlesInternosToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.definirControlesInternosToolStripMenuItem.Tag = "definir_controles_internos";
            this.definirControlesInternosToolStripMenuItem.Text = "Definir Controles Internos";
            this.definirControlesInternosToolStripMenuItem.Click += new System.EventHandler(this.definirControlesInternosToolStripMenuItem_Click);
            // 
            // evaluarMatrizDeControlToolStripMenuItem
            // 
            this.evaluarMatrizDeControlToolStripMenuItem.Name = "evaluarMatrizDeControlToolStripMenuItem";
            this.evaluarMatrizDeControlToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.evaluarMatrizDeControlToolStripMenuItem.Tag = "evaluar_matrizControl";
            this.evaluarMatrizDeControlToolStripMenuItem.Text = "Evaluar Matriz de Control";
            this.evaluarMatrizDeControlToolStripMenuItem.Click += new System.EventHandler(this.evaluarMatrizDeControlToolStripMenuItem_Click);
            // 
            // controlesObservadosToolStripMenuItem
            // 
            this.controlesObservadosToolStripMenuItem.Name = "controlesObservadosToolStripMenuItem";
            this.controlesObservadosToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.controlesObservadosToolStripMenuItem.Tag = "controles_observados";
            this.controlesObservadosToolStripMenuItem.Text = "Controles Observados";
            this.controlesObservadosToolStripMenuItem.Click += new System.EventHandler(this.controlesObservadosToolStripMenuItem_Click);
            // 
            // matrizDeControlActivaToolStripMenuItem
            // 
            this.matrizDeControlActivaToolStripMenuItem.Name = "matrizDeControlActivaToolStripMenuItem";
            this.matrizDeControlActivaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.matrizDeControlActivaToolStripMenuItem.Tag = "matriz_activa";
            this.matrizDeControlActivaToolStripMenuItem.Text = "Matriz de Control Activa";
            this.matrizDeControlActivaToolStripMenuItem.Click += new System.EventHandler(this.matrizDeControlActivaToolStripMenuItem_Click);
            // 
            // controlInternoToolStripMenuItem
            // 
            this.controlInternoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.certificarControlesToolStripMenuItem,
            this.evaluarExcepcionesToolStripMenuItem,
            this.informeDeResultadosToolStripMenuItem});
            this.controlInternoToolStripMenuItem.Enabled = false;
            this.controlInternoToolStripMenuItem.Name = "controlInternoToolStripMenuItem";
            this.controlInternoToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.controlInternoToolStripMenuItem.Tag = "etiqueta_controlInterno";
            this.controlInternoToolStripMenuItem.Text = "Control Interno";
            // 
            // certificarControlesToolStripMenuItem
            // 
            this.certificarControlesToolStripMenuItem.Name = "certificarControlesToolStripMenuItem";
            this.certificarControlesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.certificarControlesToolStripMenuItem.Tag = "certificar_control";
            this.certificarControlesToolStripMenuItem.Text = "Certificar Controles";
            this.certificarControlesToolStripMenuItem.Click += new System.EventHandler(this.certificarControlesToolStripMenuItem_Click);
            // 
            // evaluarExcepcionesToolStripMenuItem
            // 
            this.evaluarExcepcionesToolStripMenuItem.Name = "evaluarExcepcionesToolStripMenuItem";
            this.evaluarExcepcionesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.evaluarExcepcionesToolStripMenuItem.Tag = "evaluar_excepcion";
            this.evaluarExcepcionesToolStripMenuItem.Text = "Evaluar Excepciones";
            this.evaluarExcepcionesToolStripMenuItem.Click += new System.EventHandler(this.evaluarExcepcionesToolStripMenuItem_Click);
            // 
            // informeDeResultadosToolStripMenuItem
            // 
            this.informeDeResultadosToolStripMenuItem.Name = "informeDeResultadosToolStripMenuItem";
            this.informeDeResultadosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.informeDeResultadosToolStripMenuItem.Tag = "informe_resultado";
            this.informeDeResultadosToolStripMenuItem.Text = "Informe de Resultados";
            this.informeDeResultadosToolStripMenuItem.Click += new System.EventHandler(this.informeDeResultadosToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.areasDeNegocioToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.privilegiosToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.bitacoraToolStripMenuItem});
            this.seguridadToolStripMenuItem.Enabled = false;
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Tag = "menu_seguridad";
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // areasDeNegocioToolStripMenuItem
            // 
            this.areasDeNegocioToolStripMenuItem.Name = "areasDeNegocioToolStripMenuItem";
            this.areasDeNegocioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.areasDeNegocioToolStripMenuItem.Tag = "areas_negocio";
            this.areasDeNegocioToolStripMenuItem.Text = "Areas de Negocio";
            this.areasDeNegocioToolStripMenuItem.Click += new System.EventHandler(this.areasDeNegocioToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuariosToolStripMenuItem.Tag = "usuarios";
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // privilegiosToolStripMenuItem
            // 
            this.privilegiosToolStripMenuItem.Name = "privilegiosToolStripMenuItem";
            this.privilegiosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.privilegiosToolStripMenuItem.Tag = "permisos";
            this.privilegiosToolStripMenuItem.Text = "Permisos";
            this.privilegiosToolStripMenuItem.Click += new System.EventHandler(this.privilegiosToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rolesToolStripMenuItem.Tag = "roles";
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bitacoraToolStripMenuItem.Tag = "bitacora";
            this.bitacoraToolStripMenuItem.Text = "Bitacora";
            this.bitacoraToolStripMenuItem.Click += new System.EventHandler(this.bitacoraToolStripMenuItem_Click);
            // 
            // idiomaToolStripMenuItem
            // 
            this.idiomaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idiomaToolStripMenuItem1,
            this.etiquetasToolStripMenuItem,
            this.traduccionesToolStripMenuItem,
            this.cambiarIdiomaToolStripMenuItem});
            this.idiomaToolStripMenuItem.Enabled = false;
            this.idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            this.idiomaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.idiomaToolStripMenuItem.Tag = "menu_idioma";
            this.idiomaToolStripMenuItem.Text = "Idioma";
            // 
            // idiomaToolStripMenuItem1
            // 
            this.idiomaToolStripMenuItem1.Name = "idiomaToolStripMenuItem1";
            this.idiomaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.idiomaToolStripMenuItem1.Tag = "idiomas";
            this.idiomaToolStripMenuItem1.Text = "Idiomas";
            this.idiomaToolStripMenuItem1.Click += new System.EventHandler(this.idiomaToolStripMenuItem1_Click);
            // 
            // etiquetasToolStripMenuItem
            // 
            this.etiquetasToolStripMenuItem.Name = "etiquetasToolStripMenuItem";
            this.etiquetasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.etiquetasToolStripMenuItem.Tag = "etiquetas";
            this.etiquetasToolStripMenuItem.Text = "Etiquetas";
            this.etiquetasToolStripMenuItem.Click += new System.EventHandler(this.etiquetasToolStripMenuItem_Click);
            // 
            // traduccionesToolStripMenuItem
            // 
            this.traduccionesToolStripMenuItem.Name = "traduccionesToolStripMenuItem";
            this.traduccionesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.traduccionesToolStripMenuItem.Tag = "traducciones";
            this.traduccionesToolStripMenuItem.Text = "Traducciones";
            this.traduccionesToolStripMenuItem.Click += new System.EventHandler(this.traduccionesToolStripMenuItem_Click);
            // 
            // cambiarIdiomaToolStripMenuItem
            // 
            this.cambiarIdiomaToolStripMenuItem.Name = "cambiarIdiomaToolStripMenuItem";
            this.cambiarIdiomaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cambiarIdiomaToolStripMenuItem.Tag = "cambiar_idioma";
            this.cambiarIdiomaToolStripMenuItem.Text = "Cambiar Idioma";
            this.cambiarIdiomaToolStripMenuItem.Click += new System.EventHandler(this.cambiarIdiomaToolStripMenuItem_Click);
            // 
            // pruebasToolStripMenuItem
            // 
            this.pruebasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pruebaToolStripMenuItem});
            this.pruebasToolStripMenuItem.Enabled = false;
            this.pruebasToolStripMenuItem.Name = "pruebasToolStripMenuItem";
            this.pruebasToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pruebasToolStripMenuItem.Tag = "menu_prueba";
            this.pruebasToolStripMenuItem.Text = "Pruebas";
            // 
            // pruebaToolStripMenuItem
            // 
            this.pruebaToolStripMenuItem.Name = "pruebaToolStripMenuItem";
            this.pruebaToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.pruebaToolStripMenuItem.Tag = "gestion_encriptado";
            this.pruebaToolStripMenuItem.Text = "Gestión de Encriptado";
            this.pruebaToolStripMenuItem.Click += new System.EventHandler(this.pruebaToolStripMenuItem_Click);
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiaDeSeguridadToolStripMenuItem,
            this.restaurarBaseDeDatosToolStripMenuItem,
            this.controlDeIntegridadToolStripMenuItem,
            this.auditoriaRiesgosToolStripMenuItem});
            this.administracionToolStripMenuItem.Enabled = false;
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administracionToolStripMenuItem.Tag = "menu_administacion";
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // copiaDeSeguridadToolStripMenuItem
            // 
            this.copiaDeSeguridadToolStripMenuItem.Name = "copiaDeSeguridadToolStripMenuItem";
            this.copiaDeSeguridadToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.copiaDeSeguridadToolStripMenuItem.Tag = "copia_seguridad";
            this.copiaDeSeguridadToolStripMenuItem.Text = "Copia de Seguridad";
            this.copiaDeSeguridadToolStripMenuItem.Click += new System.EventHandler(this.copiaDeSeguridadToolStripMenuItem_Click);
            // 
            // restaurarBaseDeDatosToolStripMenuItem
            // 
            this.restaurarBaseDeDatosToolStripMenuItem.Name = "restaurarBaseDeDatosToolStripMenuItem";
            this.restaurarBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.restaurarBaseDeDatosToolStripMenuItem.Tag = "restaurar_bd";
            this.restaurarBaseDeDatosToolStripMenuItem.Text = "Restaurar Base de Datos";
            this.restaurarBaseDeDatosToolStripMenuItem.Visible = false;
            this.restaurarBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.restaurarBaseDeDatosToolStripMenuItem_Click);
            // 
            // controlDeIntegridadToolStripMenuItem
            // 
            this.controlDeIntegridadToolStripMenuItem.Name = "controlDeIntegridadToolStripMenuItem";
            this.controlDeIntegridadToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.controlDeIntegridadToolStripMenuItem.Tag = "control_integridad";
            this.controlDeIntegridadToolStripMenuItem.Text = "Control de Integridad";
            this.controlDeIntegridadToolStripMenuItem.Click += new System.EventHandler(this.controlDeIntegridadToolStripMenuItem_Click);
            // 
            // auditoriaRiesgosToolStripMenuItem
            // 
            this.auditoriaRiesgosToolStripMenuItem.Name = "auditoriaRiesgosToolStripMenuItem";
            this.auditoriaRiesgosToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.auditoriaRiesgosToolStripMenuItem.Tag = "auditoria_riesgo";
            this.auditoriaRiesgosToolStripMenuItem.Text = "Auditoria - Riesgos";
            this.auditoriaRiesgosToolStripMenuItem.Click += new System.EventHandler(this.auditoriaRiesgosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 518);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SCI - Sistema de Control Interno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pruebasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pruebaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privilegiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idiomaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem etiquetasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traduccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarIdiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrizDeControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riesgosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluarRiesgosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riesgosObservadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizarRelevamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem definirControlesInternosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluarMatrizDeControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlesObservadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem periodoDeControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areasDeNegocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrizDeControlActivaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiaDeSeguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlDeIntegridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditoriaRiesgosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlInternoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem certificarControlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluarExcepcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeDeResultadosToolStripMenuItem;
    }
}

