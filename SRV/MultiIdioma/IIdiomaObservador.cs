using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.MuiltiIdioma;

namespace Servicios.MultiIdioma
{
    public interface IIdiomaObservador
    {
        void ActualizarIdioma(Idioma idioma);
    }
}
