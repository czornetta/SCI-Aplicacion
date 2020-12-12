using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.DefMatrizControl;
using Mapeo.DefMatrizControl;
using Servicios.Seguridad;

namespace Negocio.DefMatrizControl
{
    public class NEstadoRiesgo
    {
        public void AgregarEstadoRiesgo(EstadoRiesgo obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("EstadoRiesgo");

                if (obj.Nombre == null)
                    throw new AtributoNotNullException("Nombre");

                (new MEstadoRiesgo()).Operacion(obj, 0);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void ModificarEstadoRiesgo(EstadoRiesgo obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("EstadoRiesgo");

                if (!(obj.Id > 0))
                    throw new AtributoNotNullException("Id");

                if (obj.Nombre == null)
                    throw new AtributoNotNullException("Nombre");

                (new MEstadoRiesgo()).Operacion(obj, 1);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void BorrarEstadoRiesgo(EstadoRiesgo obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("EstadoRiesgo");

                if (!(obj.Id > 0))
                    throw new AtributoNotNullException("Id");

                
                (new MEstadoRiesgo()).Operacion(obj, 2);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public IList<EstadoRiesgo> GetEstadosRiesgo()
        {
            return (new MEstadoRiesgo()).Leer();
        }
    }
}
