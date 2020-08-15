using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.MuiltiIdioma;
using Mapeo.MultiIdioma;

namespace Negocio.MultiIdioma
{
    public class NIdioma
    {
        #region Idioma
        public void AgregarIdioma(Idioma obj)
        {
            (new MIdioma()).OperacionIdioma(obj, 0);
        }

        public void ModificarIdioma(Idioma obj)
        {
            (new MIdioma()).OperacionIdioma(obj, 1);
        }

        public void BorrarIdioma(Idioma obj)
        {
            (new MIdioma()).OperacionIdioma(obj, 2);
        }

        public IList<Idioma> GetIdiomas()
        {
            return (new MIdioma()).GetIdiomas();
        }

        public Idioma GetIdiomaPrincipal()
        {
            return ((new MIdioma()).GetIdiomas()).FirstOrDefault(x => x.Principal==true) ;
        }
        #endregion

        #region Etiquetas
        public void AgregarEtiqueta(Etiqueta obj)
        {
            (new MIdioma()).OperacionEtiqueta(obj, 0);
        }

        public void ModificarEtiqueta(Etiqueta obj)
        {
            (new MIdioma()).OperacionEtiqueta(obj, 1);
        }

        public void BorrarEtiqueta(Etiqueta obj)
        {
            (new MIdioma()).OperacionEtiqueta(obj, 2);
        }

        public IList<Etiqueta> GetEtiquetas()
        {
            return (new MIdioma()).GetEtiquetas();
        }
        #endregion

        #region Traducciones
        public void AgregarTraduccion(Traduccion obj)
        {
            (new MIdioma()).OperacionTraduccion(obj, 0);
        }

        public void ModificarTraduccion(Traduccion obj)
        {
            (new MIdioma()).OperacionTraduccion(obj, 1);
        }

        public void BorrarTraduccion(Traduccion obj)
        {
            (new MIdioma()).OperacionTraduccion(obj, 2);
        }

        public IList<Traduccion> GetTraducciones(Idioma idm=null)
        {
            return (new MIdioma()).GetTraducciones(idm);
        }

        public Dictionary<string,string> GetDiccionario(Idioma idioma)
        {
            Dictionary<string, string> diccionario = new Dictionary<string, string>();

            foreach (var item in GetTraducciones(idioma))
            {
                diccionario.Add(item.Etiqueta.Nombre, item.Texto);
            }
            return diccionario;
        }

        #endregion
    }
}
