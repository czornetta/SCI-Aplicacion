using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.GestionBitacora
{
    public class Error : Bitacora
    {
        public override string Tipo { get { return "Error"; } }
    }
}
