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
    public class NEstadoControlInterno
    {
        public void AgregarEstadoControlInterno(EstadoControlInterno obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("EstadoControlInterno");

                if (obj.Nombre == null)
                    throw new AtributoNotNullException("Nombre");

                (new MEstadoControlInterno()).Operacion(obj, 0);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void ModificarEstadoControlInterno(EstadoControlInterno obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("EstadoControlInterno");

                if (!(obj.Id > 0))
                    throw new AtributoNotNullException("Id");

                if (obj.Nombre == null)
                    throw new AtributoNotNullException("Nombre");

                (new MEstadoControlInterno()).Operacion(obj, 1);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void BorrarEstadoControlInterno(EstadoControlInterno obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("EstadoControlInterno");

                if (!(obj.Id > 0))
                    throw new AtributoNotNullException("Id");

                (new MEstadoControlInterno()).Operacion(obj, 2);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public IList<EstadoControlInterno> GetEstadosControlInterno()
        {
            return (new MEstadoControlInterno()).Leer();
        }
    }
}
