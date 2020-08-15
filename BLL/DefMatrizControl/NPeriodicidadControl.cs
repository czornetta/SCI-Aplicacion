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
    public class NPeriodicidadControl
    {
        public void AgregarPeriodicidadControl(PeriodicidadControl obj)
        {
            (new MPeriodicidadControl()).Operacion(obj, 0);
        }

        public void ModificarPeriodicidadControl(PeriodicidadControl obj)
        {
            (new MPeriodicidadControl()).Operacion(obj, 1);
        }

        public void BorrarPeriodicidadControl(PeriodicidadControl obj)
        {
            (new MPeriodicidadControl()).Operacion(obj, 2);
        }

        public IList<PeriodicidadControl> GetPeriodicidadControles()
        {
            return (new MPeriodicidadControl()).Leer();
        }
    }
}
