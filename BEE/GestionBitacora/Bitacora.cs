using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.DefMatrizControl;
using Entidades.Seguridad;

namespace Entidades.GestionBitacora
{
    public abstract class Bitacora
    {
        //public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public abstract string Tipo { get; }
            
    }
}
