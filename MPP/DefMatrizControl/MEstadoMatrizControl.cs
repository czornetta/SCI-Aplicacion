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
    public class MEstadoMatrizControl
    {
        private string[] Sql = { "addEstadoMatrizControl", "updEstadoMatrizControl", "delEstadoMatrizControl", "getEstadosMatrizControl" };

        public void Operacion(EstadoMatrizControl obj, int ope)
        {

            Hashtable param = new Hashtable();

            try
            {
                if (ope > 0)
                {
                    param.Add("@idEstadoMatrizControl", obj.Id);
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

        public IList<EstadoMatrizControl> Leer()
        {
            List<EstadoMatrizControl> res = new List<EstadoMatrizControl>();

            try
            {

                res = (from reg in ((new Acceso()).Leer(Sql[3], new Hashtable())).Tables[0].AsEnumerable()
                       select new EstadoMatrizControl
                       {
                           Id= reg.Field<int>("idestado"),
                           Nombre = reg.Field<string>("nombre")
                       }).ToList<EstadoMatrizControl>();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return res;
        }

    }
}

