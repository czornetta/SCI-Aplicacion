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
    public class NClasificacionRiesgo
    {
        public void AgregarClasificacionRiesgo(ClasificacionRiesgo obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("ClasificacionRiesgo");

                if (obj.Nombre == null)
                    throw new AtributoNotNullException("Nombre");

                (new MClasificacionRiesgo()).Operacion(obj, 0);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void ModificarClasificacionRiesgo(ClasificacionRiesgo obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("ClasificacionRiesgo");

                if (!(obj.Id > 0))
                    throw new AtributoNotNullException("Id");

                if (obj.Nombre == null)
                    throw new AtributoNotNullException("Nombre");

                (new MClasificacionRiesgo()).Operacion(obj, 1);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }

            
        }

        public void BorrarClasificacionRiesgo(ClasificacionRiesgo obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("ClasificacionRiesgo");

                if (!(obj.Id > 0))
                    throw new AtributoNotNullException("Id");

                
                (new MClasificacionRiesgo()).Operacion(obj, 2);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public IList<ClasificacionRiesgo> GetClasificacionesRiesgo()
        {
            return (new MClasificacionRiesgo()).Leer();
        }
    }
}
