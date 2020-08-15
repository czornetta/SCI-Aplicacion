using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.DefMatrizControl
{
    public class MatrizControl
    {
        public int Id { get; set; }
        public int Periodo { get; set; }
        public EstadoMatrizControl Estado { get; set; }

        public override string ToString()
        {
            return Periodo.ToString();
        }
    }
}
