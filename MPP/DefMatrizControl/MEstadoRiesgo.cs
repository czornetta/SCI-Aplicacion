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
    public class MEstadoRiesgo
    {
        private string[] Sql = { "addEstadoRiesgo", "updEstadoRiesgo", "delEstadoRiesgo", "getEstadosRiesgo" };

        public void Operacion(EstadoRiesgo obj, int ope)
        {

            Hashtable param = new Hashtable();

            try
            {
                if (ope > 0)
                {
                    param.Add("@idEstadoRiesgo", obj.Id);
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

        public IList<EstadoRiesgo> Leer()
        {
            List<EstadoRiesgo> res = new List<EstadoRiesgo>();

            try
            {

                res = (from reg in ((new Acceso()).Leer(Sql[3], new Hashtable())).Tables[0].AsEnumerable()
                       select new EstadoRiesgo
                       {
                           Id= reg.Field<int>("idestadoriesgo"),
                           Nombre = reg.Field<string>("nombre"),
                           Clase = reg.Field<string>("clase")
                       }).ToList<EstadoRiesgo>();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return res;
        }

    }
}

