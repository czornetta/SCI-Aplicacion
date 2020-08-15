using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.MuiltiIdioma
{
    public class Idioma
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Principal { get; set; }
        public Dictionary<string,string> Diccionario { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
