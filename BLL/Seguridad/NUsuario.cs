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

        public void RecordarClave(Usuario usr)
        {
            BinaryFormatter formateador = new BinaryFormatter();
            Stream archivo;
            string nombreArchivo = "usr.dat";
            List<Usuario> lusr = new List<Usuario>();
            usr.Nombre = usr.Nombre.ToLower();

            if (File.Exists(nombreArchivo))
            {
                archivo = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read, FileShare.None);
                lusr = (List<Usuario>)formateador.Deserialize(archivo);
                archivo.Close();

                Usuario usrExiste = lusr.FirstOrDefault(x => x.Nombre == usr.Nombre);
                    
                if (usrExiste != null)
                {
                    lusr.Remove(usrExiste);
                }

                lusr.Add(usr);
            }
            else
            {
                lusr.Add(usr);
            }

            archivo = new FileStream(nombreArchivo, FileMode.Create,FileAccess.Write,FileShare.None);
            formateador.Serialize(archivo, lusr);
            archivo.Close();
        }

        public Usuario ObtenerClave(string nombre)
        {
            BinaryFormatter formateador = new BinaryFormatter();
            string nombreArchivo = "usr.dat";
            Stream archivo;
            List<Usuario> lusr;
            Usuario usr = new Usuario();
            
            if (File.Exists(nombreArchivo))
            {
                archivo = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read, FileShare.None);
                lusr = (List<Usuario>)formateador.Deserialize(archivo);
                archivo.Close();

                if (lusr != null)
                {
                    usr = lusr.FirstOrDefault(x => x.Nombre == nombre.ToLower());
                }
                
            }
            
            return usr;
        }

        public void OlvidarClave(Usuario usr)
        {
            BinaryFormatter formateador = new BinaryFormatter();
            Stream archivo;
            string nombreArchivo = "usr.dat";
            List<Usuario> lusr = new List<Usuario>();
            usr.Nombre = usr.Nombre.ToLower();

            if (File.Exists(nombreArchivo))
            {
                archivo = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read, FileShare.None);
                lusr = (List<Usuario>)formateador.Deserialize(archivo);
                archivo.Close();

                Usuario usrExiste = lusr.FirstOrDefault(x => x.Nombre == usr.Nombre);

                if (usrExiste != null)
                {
                    lusr.Remove(usrExiste);
                }
            }

            archivo = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write, FileShare.None);
            formateador.Serialize(archivo, lusr);
            archivo.Close();
        }

    }
}
