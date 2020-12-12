using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Seguridad;
using Mapeo.Seguridad;
using Servicios.Seguridad;

namespace Negocio.Seguridad
{
    public class NAreaNegocio
    {
        public void AgregarAreaNegocio(AreaNegocio obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("AreaNegocio");

                if (obj.Nombre == null)
                    throw new AtributoNotNullException("Nombre");

                (new MAreaNegocio()).Operacion(obj, 0);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void ModificarAreaNegocio(AreaNegocio obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("AreaNegocio");

                if (!(obj.Id > 0))
                    throw new AtributoNotNullException("Id");

                if (obj.Nombre == null)
                    throw new AtributoNotNullException("Nombre");

                (new MAreaNegocio()).Operacion(obj, 1);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void BorrarAreaNegocio(AreaNegocio obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("AreaNegocio");

                if (!(obj.Id > 0))
                    throw new AtributoNotNullException("Id");

                (new MAreaNegocio()).Operacion(obj, 2);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public IList<AreaNegocio> GetAreasNegocio()
        {
            return (new MAreaNegocio()).Leer();
        }

    }
}
