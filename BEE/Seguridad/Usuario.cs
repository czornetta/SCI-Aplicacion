using Entidades.DefMatrizControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Seguridad
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public AreaNegocio AreaNegocio { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
