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
    public class MPeriodicidadControl
    {
        private string[] Sql = { "addPeriodicidadControl", "updPeriodicidadControl", "delPeriodicidadControl", "getPeriodicidadControl" };

        public void Operacion(PeriodicidadControl obj, int ope)
        {

            Hashtable param = new Hashtable();

            try
            {
                if (ope > 0)
                {
                    param.Add("@idPeriodicidadControl", obj.Id);
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

        public IList<PeriodicidadControl> Leer()
        {
            List<PeriodicidadControl> res = new List<PeriodicidadControl>();

            try
            {

                res = (from reg in ((new Acceso()).Leer(Sql[3], new Hashtable())).Tables[0].AsEnumerable()
                       select new PeriodicidadControl
                       {
                           Id= reg.Field<int>("idperiodicidad"),
                           Nombre = reg.Field<string>("nombre")
                       }).ToList<PeriodicidadControl>();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return res;
        }

    }
}

