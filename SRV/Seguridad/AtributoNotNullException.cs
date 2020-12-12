using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad
{
    public class AtributoNotNullException : Exception
    {
        public AtributoNotNullException(string atributo)
            :base(atributo + " es Obligatorio.") { }
    }
}
