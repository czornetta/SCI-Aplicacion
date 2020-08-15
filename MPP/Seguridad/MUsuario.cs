using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Seguridad;
using AccesoDatos;
using System.Collections;
using System.Data;

namespace Mapeo.Seguridad
{
    public class MUsuario
    {
        private string[] Sql = { "addUsuario", "updUsuario", "delUsuario", "getUsuarios" };

        public void Operacion(Usuario obj, int ope)
        {
            
            Hashtable param = new Hashtable();

            try
            {
                if (ope > 0)
                {
                    param.Add("@idUsuario", obj.IdUsuario);
                }

                if (ope < 2)
                {
                    param.Add("@nombre", obj.Nombre);
                    param.Add("@clave", obj.Clave);
                    param.Add("@idareanegocio", obj.AreaNegocio.Id);
                }

                (new Acceso()).Escribir(Sql[ope], param);
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
                           AreaNegocio = lAreaNegocio.FirstOrDefault(x => x.Id == reg.Field<int>("idareanegocio"))
                       }).ToList <Usuario>();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return res;
        }
    }
}
