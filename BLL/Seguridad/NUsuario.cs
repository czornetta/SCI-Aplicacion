using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Seguridad;
using Mapeo.Seguridad;
using Negocio.MultiIdioma;
using Servicios.Seguridad;
using Entidades.GestionBitacora;
using Negocio.GestionBitacora;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Negocio.Seguridad
{
    public class NUsuario
    {
        public void Operacion(Usuario obj, int ope)
        {
            
            (new MUsuario()).Operacion(obj, ope);

        }

        public IList<Usuario> Leer()
        {
            return (new MUsuario()).Leer();
        }

        public void VerificarDatosObligatorios(Usuario obj)
        {
            try
            {
                if (obj.Nombre == null)
                    throw new AtributoNotNullException("Nombre");

                if (obj.Clave == null)
                    throw new AtributoNotNullException("Clave");

                if (obj.AreaNegocio == null)
                    throw new AtributoNotNullException("AreaNegocio");

                if (!(obj.AreaNegocio.Id > 0))
                    throw new AtributoNotNullException("AreaNegocio.Id");
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
        }

        public void DatosLoginOK(string nombre, string clave)
        {
            try
            {
                if (nombre == null)
                    throw new LoginException(LoginResult.InvalidUsername);

                if (clave == null)
                    throw new LoginException(LoginResult.InvalidPassword);

            }
            catch (Exception ex) when (ex.GetType() != typeof(LoginException))
            {
                throw new Exception(ex.Message);
            }
        }

        public LoginResult IniciarSesion(string nombre, string clave) 
        {
            try
            {
                DatosLoginOK(nombre, clave);

                if (Sesion.SesionActiva())
                    throw new LoginException(LoginResult.ExistsActiveSesion);

                var Usuarios = Leer();
                Usuario usuario = Usuarios.Where(u => u.Nombre.ToLower().Equals(nombre.ToLower())).FirstOrDefault();

                if (usuario==null)
                    throw new LoginException(LoginResult.InvalidUsername);

                if (!usuario.Clave.Equals(Cifrado.Cifrar(clave)))
                {
                    Bitacora registro = new Error();
                    registro.Fecha = DateTime.Now;
                    registro.Usuario = usuario;
                    registro.Descripcion = LoginResult.InvalidPassword.ToString();
                    (new NBitacora()).AgregarRegistro(registro);
                    
                    throw new LoginException(LoginResult.InvalidPassword);
                }

                Sesion.IniciarSesion(usuario);
                Sesion.Instancia.Privilegios = (new NPrivilegio()).GetPrivilegios(usuario);
                Sesion.Instancia.Idioma = (new NIdioma()).GetIdiomaPrincipal();
            }
            
            catch (Exception ex) when (ex.GetType() != typeof(LoginException))
            {
                throw new Exception(ex.Message);
            }

            return LoginResult.ValidUser;
        }

        public void CerrarSesion()
        {
            Sesion.CerrarSesion();
        }

        public void RecordarClave(Usuario usr)
        {
            (new MUsuario()).RecordarClave(usr);
        }

        public Usuario ObtenerClave(string nombre)
        {
            return (new MUsuario()).ObtenerClave(nombre);
        }

        public void OlvidarClave(Usuario usr)
        {
            (new MUsuario()).OlvidarClave(usr);
        }

    }
}
