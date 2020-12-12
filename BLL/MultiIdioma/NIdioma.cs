using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.MuiltiIdioma;
using Mapeo.MultiIdioma;
using Servicios.Seguridad;

namespace Negocio.MultiIdioma
{
    public class NIdioma
    {
        #region Idioma
        public void AgregarIdioma(Idioma obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("Idioma");

                
                if (obj.Nombre == null)
                    throw new AtributoNotNullException("Nombre");

                (new MIdioma()).OperacionIdioma(obj, 0);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void ModificarIdioma(Idioma obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("Idioma");

                if (!(obj.Id > 0))
                    throw new AtributoNotNullException("Id");

                if (obj.Nombre == null)
                    throw new AtributoNotNullException("Nombre");

                (new MIdioma()).OperacionIdioma(obj, 1);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void BorrarIdioma(Idioma obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("Idioma");

                if (!(obj.Id > 0))
                    throw new AtributoNotNullException("Id");

                (new MIdioma()).OperacionIdioma(obj, 2);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
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
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("Etiqueta");

                
                if (obj.Nombre == null)
                    throw new AtributoNotNullException("Nombre");

                (new MIdioma()).OperacionEtiqueta(obj, 0);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void ModificarEtiqueta(Etiqueta obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("Etiqueta");

                if (!(obj.Id > 0))
                    throw new AtributoNotNullException("Id");

                if (obj.Nombre == null)
                    throw new AtributoNotNullException("Nombre");

                (new MIdioma()).OperacionEtiqueta(obj, 1);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void BorrarEtiqueta(Etiqueta obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("Etiqueta");

                if (!(obj.Id > 0))
                    throw new AtributoNotNullException("Id");

                (new MIdioma()).OperacionEtiqueta(obj, 2);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public IList<Etiqueta> GetEtiquetas()
        {
            return (new MIdioma()).GetEtiquetas();
        }
        #endregion

        #region Traducciones
        public void AgregarTraduccion(Traduccion obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("Traduccion");

                if (obj.Idioma == null)
                    throw new AtributoNotNullException("Idioma");

                if (obj.Etiqueta == null)
                    throw new AtributoNotNullException("Etiqueta");

                if (obj.Texto == null)
                    throw new AtributoNotNullException("Texto");

                (new MIdioma()).OperacionTraduccion(obj, 0);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void ModificarTraduccion(Traduccion obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("Traduccion");

                if (obj.Idioma == null)
                    throw new AtributoNotNullException("Idioma");

                if (obj.Etiqueta == null)
                    throw new AtributoNotNullException("Etiqueta");

                if (obj.Texto == null)
                    throw new AtributoNotNullException("Texto");

                (new MIdioma()).OperacionTraduccion(obj, 1);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void BorrarTraduccion(Traduccion obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("Traduccion");

                if (obj.Idioma == null)
                    throw new AtributoNotNullException("Idioma");

                if (obj.Etiqueta == null)
                    throw new AtributoNotNullException("Etiqueta");

                (new MIdioma()).OperacionTraduccion(obj, 2);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
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
