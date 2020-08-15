using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.MuiltiIdioma;

namespace Servicios.MultiIdioma
{
    public interface IIdioma
    {
        void SuscribirObservador(IIdiomaObservador obs);
        void DesuscribirObservador(IIdiomaObservador obs);
        void Notificar(Idioma idm);
    }
}
