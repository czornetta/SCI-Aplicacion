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
    public class NPeriodicidadControl
    {
        public void AgregarPeriodicidadControl(PeriodicidadControl obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("PeriodicidadControl");

                if (obj.Nombre == null)
                    throw new AtributoNotNullException("Nombre");

                (new MPeriodicidadControl()).Operacion(obj, 0);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void ModificarPeriodicidadControl(PeriodicidadControl obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("PeriodicidadControl");

                if (!(obj.Id > 0))
                    throw new AtributoNotNullException("Id");

                if (obj.Nombre == null)
                    throw new AtributoNotNullException("Nombre");

                (new MPeriodicidadControl()).Operacion(obj, 1);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void BorrarPeriodicidadControl(PeriodicidadControl obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("PeriodicidadControl");

                if (!(obj.Id > 0))
                    throw new AtributoNotNullException("Id");

                (new MPeriodicidadControl()).Operacion(obj, 2);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public IList<PeriodicidadControl> GetPeriodicidadControles()
        {
            return (new MPeriodicidadControl()).Leer();
        }
    }
}
