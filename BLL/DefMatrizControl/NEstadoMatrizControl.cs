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
    public class NEstadoMatrizControl
    {
        public void Agregar(EstadoMatrizControl obj)
        {
            (new MEstadoMatrizControl()).Operacion(obj, 0);
        }

        public void Modificar(EstadoMatrizControl obj)
        {
            (new MEstadoMatrizControl()).Operacion(obj, 1);
        }

        public void BorrarEstadoRiesgo(EstadoMatrizControl obj)
        {
            (new MEstadoMatrizControl()).Operacion(obj, 2);
        }

        public IList<EstadoMatrizControl> GetEstados()
        {
            return (new MEstadoMatrizControl()).Leer();
        }
    }
}
