using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Seguridad;
using Entidades.DefMatrizControl;
using System.Runtime.CompilerServices;

namespace Entidades.Auditoria
{
    public class RiesgoAudit
    {
        public int Id { get; set; }
        public int IdRiesgo { get; set; }
        public string Nombre { get; set; }
        public AreaNegocio AreaNegocio { get; set; }
        public ClasificacionRiesgo Clasificacion { get; set; }
        public MatrizControl MatrizControl { get; set; }
        public EstadoRiesgo EstadoRiesgo { get; set; }
        public string Observacion { get; set; }
        public string Comentario { get; set; }
        public string TipoTransaccion { get; set; }
        public DateTime Fecha { get; set; }
        public Usuario UsuarioTRX { get; set; }
        
        public override string ToString()
        {
            return Nombre;
        }
    }
}
