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
    public class NEstadoRiesgo
    {
        public void AgregarEstadoRiesgo(EstadoRiesgo obj)
        {
            (new MEstadoRiesgo()).Operacion(obj, 0);
        }

        public void ModificarEstadoRiesgo(EstadoRiesgo obj)
        {
            (new MEstadoRiesgo()).Operacion(obj, 1);
        }

        public void BorrarEstadoRiesgo(EstadoRiesgo obj)
        {
            (new MEstadoRiesgo()).Operacion(obj, 2);
        }

        public IList<EstadoRiesgo> GetEstadosRiesgo()
        {
            return (new MEstadoRiesgo()).Leer();
        }
    }
}
