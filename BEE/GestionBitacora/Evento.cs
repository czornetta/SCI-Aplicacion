using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.GestionBitacora
{
    public class Evento : Bitacora
    {
        public override string Tipo { get { return "Evento"; } }
    }
}
