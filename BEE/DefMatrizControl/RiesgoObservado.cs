using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Seguridad;

namespace Entidades.DefMatrizControl
{
    public class RiesgoObservado:Riesgo
    {
        public RiesgoObservado(MatrizControl mc, AreaNegocio an, ClasificacionRiesgo cla) : base(mc, an, cla)
        {

        }
        public RiesgoObservado(int id, string no, MatrizControl mc, AreaNegocio an, ClasificacionRiesgo cla, string obs, string com) : base(id, no, mc, an, cla, obs, com)
        {

        }
    }
}
