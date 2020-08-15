using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades.DefMatrizControl;
using System.Collections;
using System.Data;
using Mapeo.Seguridad;

namespace Mapeo.DefMatrizControl
{
    public class MClasificacionRiesgo
    {
        private string[] Sql = { "addClasificacionRiesgo", "updClasificacionRiesgo", "delClasificacionRiesgo", "getClasificacionesRiesgo" };

        public void Operacion(ClasificacionRiesgo obj, int ope)
        {

            Hashtable param = new Hashtable();

            try
            {
                if (ope > 0)
                {
                    param.Add("@idClasificacionRiesgo", obj.Id);
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

        public IList<ClasificacionRiesgo> Leer()
        {
            List<ClasificacionRiesgo> res = new List<ClasificacionRiesgo>();

            try
            {

                res = (from reg in ((new Acceso()).Leer(Sql[3], new Hashtable())).Tables[0].AsEnumerable()
                       select new ClasificacionRiesgo
                       {
                           Id= reg.Field<int>("idclasificacionriesgo"),
                           Nombre = reg.Field<string>("nombre")
                       }).ToList<ClasificacionRiesgo>();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return res;
        }

    }
}

