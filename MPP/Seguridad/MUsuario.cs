using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Seguridad;
using Entidades.GestionIntegridad;
using Servicios.GestionIntegridad;
using Servicios.Seguridad;
using AccesoDatos;
using System.Collections;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Mapeo.Seguridad
{
    public class MUsuario
    {
        private string[] Sql = { "addUsuario", "updUsuario", "delUsuario", "getUsuarios" };

        public void Operacion(Usuario obj, int ope)
        {
            
            Hashtable param = new Hashtable();
            ControlIntegridad controlIntegridad = new ControlIntegridad();

            try
            {
                var lObj = Leer();
                lObj.Remove(lObj.Where(x => x.IdUsuario == obj.IdUsuario).FirstOrDefault());
                obj.DigitoVerificador = controlIntegridad.GetDVH(obj.Registro);

                switch (ope)
                {
                    case 0:
                        param.Add("@nombre", obj.Nombre);
                        param.Add("@clave", obj.Clave);
                        param.Add("@idareanegocio", obj.AreaNegocio.Id);
                        param.Add("@dvregistro", obj.DigitoVerificador);
                        lObj.Add(obj);
                        break;

                    case 1:
                        param.Add("@idUsuario", obj.IdUsuario);
                        param.Add("@nombre", obj.Nombre);
                        param.Add("@clave", obj.Clave);
                        param.Add("@idareanegocio", obj.AreaNegocio.Id);
                        param.Add("@dvregistro", obj.DigitoVerificador);
                        lObj.Add(obj);
                        break;
                    case 2:
                        param.Add("@idUsuario", obj.IdUsuario);
                        break;
                    default:
                        break;
                }
                
                // digito verificador vertical
                DVEntidad dvv = controlIntegridad.GetDVV("Usuario", lObj.ToList<Integridad>());
                
                (new Acceso()).Escribir(Sql[ope], param,dvv);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        public IList<Usuario> Leer()
        {
            List<Usuario> res = new List<Usuario>();

            try
            {
                var lAreaNegocio = (new MAreaNegocio()).Leer();

                res = (from reg in ((new Acceso()).Leer(Sql[3], new Hashtable())).Tables[0].AsEnumerable()
                       select new Usuario
                       {
                           IdUsuario = reg.Field<int>("idusuario"),
                           Nombre = reg.Field<string>("nombre"),
                           Clave = reg.Field<string>("clave"),
                           AreaNegocio = lAreaNegocio.FirstOrDefault(x => x.Id == reg.Field<int>("idareanegocio")),
                           DigitoVerificador = reg.Field<string>("dvregistro"),
                       }).ToList <Usuario>();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return res;
        }

        public void RecordarClave(Usuario usr)
        {
            BinaryFormatter formateador = new BinaryFormatter();
            Stream archivo;
            string nombreArchivo = "usr.dat";
            List<Usuario> lusr = new List<Usuario>();

            try
            {
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

                archivo = new FileStream(nombreArchivo, FileMode.Create, FileAccess.Write, FileShare.None);
                formateador.Serialize(archivo, lusr);
                archivo.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        public Usuario ObtenerClave(string nombre)
        {
            BinaryFormatter formateador = new BinaryFormatter();
            string nombreArchivo = "usr.dat";
            Stream archivo;
            List<Usuario> lusr;
            Usuario usr = new Usuario();

            try
            {
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
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            

            return usr;
        }

        public void OlvidarClave(Usuario usr)
        {
            BinaryFormatter formateador = new BinaryFormatter();
            Stream archivo;
            string nombreArchivo = "usr.dat";
            List<Usuario> lusr = new List<Usuario>();

            try
            {
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
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }
    }
}
