using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades.Seguridad;
using System.Collections;
using System.Data;

namespace Mapeo.Seguridad
{
    public class MAreaNegocio
    {
        private string[] Sql = { "addAreaNegocio", "updAreaNegocio", "delAreaNegocio", "getAreasNegocio" };

        public void Operacion(AreaNegocio obj, int ope)
        {

            Hashtable param = new Hashtable();

            try
            {
                if (ope > 0)
                {
                    param.Add("@idAreaNegocio", obj.Id);
                }

                if (ope < 2)
                {
                    param.Add("@nombre", obj.Nombre);
                }

                (new Acceso()).Escribir(Sql[ope], param);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }

        public IList<AreaNegocio> Leer()
        {
            List<AreaNegocio> res = new List<AreaNegocio>();

            try
            {

                res = (from reg in ((new Acceso()).Leer(Sql[3], new Hashtable())).Tables[0].AsEnumerable()
                       select new AreaNegocio
                       {
                           Id = reg.Field<int>("idAreaNegocio"),
                           Nombre = reg.Field<string>("nombre")
                       }).ToList<AreaNegocio>();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return res;
        }
    }
}
