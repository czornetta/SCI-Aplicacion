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
    public class NEstadoControlInterno
    {
        public void AgregarEstadoControlInterno(EstadoControlInterno obj)
        {
            (new MEstadoControlInterno()).Operacion(obj, 0);
        }

        public void ModificarEstadoControlInterno(EstadoControlInterno obj)
        {
            (new MEstadoControlInterno()).Operacion(obj, 1);
        }

        public void BorrarEstadoControlInterno(EstadoControlInterno obj)
        {
            (new MEstadoControlInterno()).Operacion(obj, 2);
        }

        public IList<EstadoControlInterno> GetEstadosControlInterno()
        {
            return (new MEstadoControlInterno()).Leer();
        }
    }
}
