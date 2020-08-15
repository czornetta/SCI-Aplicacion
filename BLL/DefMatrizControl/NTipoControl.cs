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
    public class NTipoControl
    {
        public void AgregarTipoControl(TipoControl obj)
        {
            (new MTipoControl()).Operacion(obj, 0);
        }

        public void ModificarTipoControl(TipoControl obj)
        {
            (new MTipoControl()).Operacion(obj, 1);
        }

        public void BorrarTipoControl(TipoControl obj)
        {
            (new MTipoControl()).Operacion(obj, 2);
        }

        public IList<TipoControl> GetTiposControles()
        {
            return (new MTipoControl()).Leer();
        }
    }
}
