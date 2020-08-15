using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Seguridad;

namespace Entidades.DefMatrizControl
{
    public class ControlInternoPropuesto:ControlInterno
    {
        public ControlInternoPropuesto(Riesgo r, TipoControl t, PeriodicidadControl p) : base(r, t, p)
        {

        }
        public ControlInternoPropuesto(int id, string no, string de, Riesgo r, TipoControl t, PeriodicidadControl p, string obs, string com) : base(id, no, de, r, t, p, obs, com)
        {

        }

    }
}
