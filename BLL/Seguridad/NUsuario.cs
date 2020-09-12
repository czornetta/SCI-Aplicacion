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

        public LoginResult IniciarSesion(string nombre, string clave) 
        {
            try
            {
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
            catch (LoginException ex)
            {
                throw new LoginException(ex.Result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return LoginResult.ValidUser;
        }

        public void CerrarSesion()
        {
            Sesion.CerrarSesion();
        }
    }
}
