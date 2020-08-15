using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.DefMatrizControl
{
    public class EstadoControlInterno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Clase { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
