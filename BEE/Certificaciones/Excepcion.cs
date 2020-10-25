using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Certificaciones
{
    public class Excepcion
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public EstadoExcepcion Estado { get; set; }    

        public Excepcion()
        {
            Estado = new EstadoExcepcion();
        }

        public override string ToString()
        {
            string t = ""  + Descripcion;

            if (Descripcion != null)
            {
                t = Descripcion + " - " + Estado.Nombre;
            }
            return t;
        }
        
    }
}
