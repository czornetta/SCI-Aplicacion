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
    public class NTipoControl
    {
        public void AgregarTipoControl(TipoControl obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("TipoControl");

                if (obj.Nombre == null)
                    throw new AtributoNotNullException("Nombre");

                (new MTipoControl()).Operacion(obj, 0);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void ModificarTipoControl(TipoControl obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("TipoControl");

                if (!(obj.Id > 0))
                    throw new AtributoNotNullException("Id");

                if (obj.Nombre == null)
                    throw new AtributoNotNullException("Nombre");

                (new MTipoControl()).Operacion(obj, 1);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void BorrarTipoControl(TipoControl obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("TipoControl");

                if (!(obj.Id > 0))
                    throw new AtributoNotNullException("Id");

                (new MTipoControl()).Operacion(obj, 2);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public IList<TipoControl> GetTiposControles()
        {
            return (new MTipoControl()).Leer();
        }
    }
}
