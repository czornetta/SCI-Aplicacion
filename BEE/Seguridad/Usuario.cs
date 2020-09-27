using Entidades.DefMatrizControl;
using Entidades.GestionIntegridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Seguridad
{
    public class Usuario:Integridad
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public AreaNegocio AreaNegocio { get; set; }
        public override string Registro 
        {get
            {
                return string.Concat(Nombre, Clave, AreaNegocio.Id);
            }
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
