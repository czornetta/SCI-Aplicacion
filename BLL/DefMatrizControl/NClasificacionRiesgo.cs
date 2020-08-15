using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.DefMatrizControl;
using Mapeo.DefMatrizControl;

namespace Negocio.DefMatrizControl
{
    public class NClasificacionRiesgo
    {
        public void AgregarClasificacionRiesgo(ClasificacionRiesgo obj)
        {
            (new MClasificacionRiesgo()).Operacion(obj, 0);
        }

        public void ModificarClasificacionRiesgo(ClasificacionRiesgo obj)
        {
            (new MClasificacionRiesgo()).Operacion(obj, 1);
        }

        public void BorrarClasificacionRiesgo(ClasificacionRiesgo obj)
        {
            (new MClasificacionRiesgo()).Operacion(obj, 2);
        }

        public IList<ClasificacionRiesgo> GetClasificacionesRiesgo()
        {
            return (new MClasificacionRiesgo()).Leer();
        }
    }
}
