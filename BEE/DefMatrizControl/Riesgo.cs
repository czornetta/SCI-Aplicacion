using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Seguridad;

namespace Entidades.DefMatrizControl
{
    public abstract class Riesgo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public AreaNegocio AreaNegocio { get; set; }
        public ClasificacionRiesgo Clasificacion { get; set; }
        public MatrizControl MatrizControl { get; set; }
        public string Observacion { get; set; }
        public string Comentario { get; set; }

        public Riesgo(MatrizControl m, AreaNegocio a, ClasificacionRiesgo c)
        {
            MatrizControl = m;
            AreaNegocio = a;
            Clasificacion = c;
        }

        public Riesgo(int id, string no, MatrizControl mc, AreaNegocio an, ClasificacionRiesgo cla, string obs, string com)
        {
            Id = id;
            Nombre = no;
            MatrizControl = mc;
            AreaNegocio = an;
            Clasificacion = cla;
            Observacion = obs;
            Comentario = com;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
