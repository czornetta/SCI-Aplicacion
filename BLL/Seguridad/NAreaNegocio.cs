using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Seguridad;
using Mapeo.Seguridad;

namespace Negocio.Seguridad
{
    public class NAreaNegocio
    {
        public void AgregarAreaNegocio(AreaNegocio obj)
        {
            (new MAreaNegocio()).Operacion(obj, 0);
        }

        public void ModificarAreaNegocio(AreaNegocio obj)
        {
            (new MAreaNegocio()).Operacion(obj, 1);
        }

        public void BorrarAreaNegocio(AreaNegocio obj)
        {
            (new MAreaNegocio()).Operacion(obj, 2);
        }

        public IList<AreaNegocio> GetAreasNegocio()
        {
            return (new MAreaNegocio()).Leer();
        }

    }
}
