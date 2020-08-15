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
    public class MEstadoControlInterno
    {
        private string[] Sql = { "addEstadoControlInterno", "updEstadoControlInterno", "delEstadoControlInterno", "getEstadosControlInterno" };

        public void Operacion(EstadoControlInterno obj, int ope)
        {

            Hashtable param = new Hashtable();

            try
            {
                if (ope > 0)
                {
                    param.Add("@idEstadoControlInterno", obj.Id);
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

        public IList<EstadoControlInterno> Leer()
        {
            List<EstadoControlInterno> res = new List<EstadoControlInterno>();

            try
            {

                res = (from reg in ((new Acceso()).Leer(Sql[3], new Hashtable())).Tables[0].AsEnumerable()
                       select new EstadoControlInterno
                       {
                           Id= reg.Field<int>("idestadocontrolinterno"),
                           Nombre = reg.Field<string>("nombre"),
                           Clase = reg.Field<string>("clase")
                       }).ToList<EstadoControlInterno>();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return res;
        }

    }
}

