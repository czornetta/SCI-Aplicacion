using Entidades.DefMatrizControl;
using Entidades.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Certificaciones
{
    public class Certificacion
    {
        private Excepcion _Excepcion;
        private Incidente _Incidente;

        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public ControlInternoAceptado ControlInterno {get; set;}
        public ResultadoCertificacion Resultado { get; set; }
        public Usuario Usuario { get; set; }
        public Excepcion Excepcion { get { return _Excepcion; }}
        public Incidente Incidente { get { return _Incidente; }}
        
        public Certificacion()
        {
            _Excepcion = new Excepcion();
            _Incidente = new Incidente();
        }

        public override string ToString()
        {
            return ControlInterno.ToString();
        }
    }
}
