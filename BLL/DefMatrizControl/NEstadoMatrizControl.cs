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
    public class NEstadoMatrizControl
    {
        public void Agregar(EstadoMatrizControl obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("EstadoMatrizControl");

                if (obj.Nombre == null)
                    throw new AtributoNotNullException("Nombre");

                (new MEstadoMatrizControl()).Operacion(obj, 0);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void Modificar(EstadoMatrizControl obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("EstadoMatrizControl");

                if (!(obj.Id > 0))
                    throw new AtributoNotNullException("Id");

                if (obj.Nombre == null)
                    throw new AtributoNotNullException("Nombre");

                (new MEstadoMatrizControl()).Operacion(obj, 1);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void BorrarEstadoRiesgo(EstadoMatrizControl obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("EstadoMatrizControl");

                if (!(obj.Id > 0))
                    throw new AtributoNotNullException("Id");

                (new MEstadoMatrizControl()).Operacion(obj, 2);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public IList<EstadoMatrizControl> GetEstados()
        {
            return (new MEstadoMatrizControl()).Leer();
        }
    }
}
