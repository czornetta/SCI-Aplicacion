using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.MuiltiIdioma
{
    public class Traduccion
    {
        public Idioma Idioma { get; set; }
        public Etiqueta Etiqueta { get; set; }
        public string Texto { get; set; }

    }
}
