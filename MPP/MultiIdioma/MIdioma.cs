using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.MuiltiIdioma;
using AccesoDatos;
using System.Collections;
using System.Data;
using Servicios.Seguridad;

namespace Mapeo.MultiIdioma
{
    public class MIdioma
    {
        private string[] SqlIdioma = { "addIdioma", "updIdioma", "delIdioma", "getIdiomas" };
        private string[] SqlEtiqueta = { "addEtiqueta", "updEtiqueta", "delEtiqueta", "getEtiquetas" };
        private string[] SqlTraduccion = { "addTraduccion", "updTraduccion", "delTraduccion", "getTraducciones" };

        #region Idiomas
        public void OperacionIdioma(Idioma obj, int ope)
        {

            Hashtable param = new Hashtable();

            try
            {
                if (ope > 0)
                {
                    param.Add("@idIdioma", obj.Id);
                }

                if (ope < 2)
                {
                    param.Add("@nombre", obj.Nombre);
                    param.Add("@principal", obj.Principal);
                }

                (new Acceso()).Escribir(SqlIdioma[ope], param);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }

        public IList<Idioma> GetIdiomas()
        {
            List<Idioma> res = new List<Idioma>();

            try
            {
                res = (from reg in ((new Acceso()).Leer(SqlIdioma[3], new Hashtable())).Tables[0].AsEnumerable()
                       select new Idioma
                       {
                           Id = reg.Field<int>("idIdioma"),
                           Nombre = reg.Field<string>("nombre"),
                           Principal = reg.Field<bool>("principal")
                       }).ToList<Idioma>();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return res;
        }
        #endregion

        #region Etiquetas
        public void OperacionEtiqueta(Etiqueta obj, int ope)
        {

            Hashtable param = new Hashtable();

            try
            {
                if (ope > 0)
                {
                    param.Add("@idEtiqueta", obj.Id);
                }

                if (ope < 2)
                {
                    param.Add("@nombre", obj.Nombre);;
                }

                (new Acceso()).Escribir(SqlEtiqueta[ope], param);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }

        public IList<Etiqueta> GetEtiquetas()
        {
            List<Etiqueta> res = new List<Etiqueta>();

            try
            {
                res = (from reg in ((new Acceso()).Leer(SqlEtiqueta[3], new Hashtable())).Tables[0].AsEnumerable()
                       select new Etiqueta
                       {
                           Id = reg.Field<int>("idEtiqueta"),
                           Nombre = reg.Field<string>("nombre")
                       }).ToList<Etiqueta>();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return res;
        }
        #endregion

        #region Traducciones
        public void OperacionTraduccion(Traduccion obj, int ope)
        {

            Hashtable param = new Hashtable();

            try
            {
                param.Add("@idIdioma", obj.Idioma.Id);
                param.Add("@idEtiqueta", obj.Etiqueta.Id);

                if (ope < 2)
                {
                    param.Add("@traduccion", obj.Texto);
                    
                }

                (new Acceso()).Escribir(SqlTraduccion[ope], param);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }

        public IList<Traduccion> GetTraducciones(Idioma idioma=null)
        {
            List<Traduccion> res = new List<Traduccion>();
            Hashtable param = new Hashtable();
            try
            {
                if (idioma != null)
                    param.Add("@idIdioma", idioma.Id);
                else
                    param.Add("@idIdioma", DBNull.Value);

                res = (from reg in ((new Acceso()).Leer(SqlTraduccion[3], param)).Tables[0].AsEnumerable()
                       select new Traduccion
                       {
                           Idioma = new Idioma
                           {
                               Id = reg.Field<int>("idIdioma"),
                               Nombre = reg.Field<string>("nombreIdioma"),
                               Principal = reg.Field<bool>("principal")
                           },
                           Etiqueta = new Etiqueta
                           {
                               Id = reg.Field<int>("idEtiqueta"),
                               Nombre = reg.Field<string>("nombreEtiqueta")
                           },
                           Texto = reg.Field<string>("traduccion")
                       }).ToList<Traduccion>();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return res;
        }
        #endregion

    }
}
