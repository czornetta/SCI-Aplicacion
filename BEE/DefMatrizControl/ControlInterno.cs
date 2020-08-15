using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Seguridad;

namespace Entidades.DefMatrizControl
{
    public abstract class ControlInterno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public TipoControl Tipo { get; set; }
        public PeriodicidadControl Periodicidad { get; set; }
        public Riesgo Riesgo { get; set; }
        public string Observacion { get; set; }
        public string Comentario { get; set; }

        public ControlInterno(Riesgo r, TipoControl t, PeriodicidadControl p)
        {
            Riesgo = r;
            Tipo = t;
            Periodicidad = p;
        }

        public ControlInterno(int id, string no, string de, Riesgo r, TipoControl t, PeriodicidadControl p, string obs, string com)
        {
            Id = id;
            Nombre = no;
            Descripcion = de;
            Riesgo = r;
            Tipo = t;
            Periodicidad = p;
            Observacion = obs;
            Comentario = com;
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
