using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Entidades.GestionIntegridad;
using AccesoDatos;
using System.Data;

namespace Servicios.GestionIntegridad
{
    public class MControlIntegridad
    {
        public IList<DVEntidad> GetEntidades()
        {
            try
            {
                var res = (from reg in ((new Acceso()).Leer("getDVEntidad", new Hashtable())).Tables[0].AsEnumerable()
                           select new DVEntidad
                           {
                               Id = reg.Field<int>("iddventidad"),
                               Entidad = reg.Field<string>("entidad"),
                               DigitoVerificador = reg.Field<string>("dventidad")
                           }).ToList<DVEntidad>();

                return res;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
