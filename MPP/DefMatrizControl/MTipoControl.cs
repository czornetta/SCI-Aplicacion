using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Entidades.DefMatrizControl;
using System.Collections;
using System.Data;
using Mapeo.Seguridad;

namespace Mapeo.DefMatrizControl
{
    public class MTipoControl
    {
        private string[] Sql = { "addTipoControl", "updTipoControl", "delTipoControl", "getTipoControl" };

        public void Operacion(TipoControl obj, int ope)
        {

            Hashtable param = new Hashtable();

            try
            {
                if (ope > 0)
                {
                    param.Add("@idtipoControl", obj.Id);
                }

                if (ope < 2)
                {
                    param.Add("@nombre", obj.Nombre);
                }

                (new Acceso()).Escribir(Sql[ope], param);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }

        public IList<TipoControl> Leer()
        {
            List<TipoControl> res = new List<TipoControl>();

            try
            {

                res = (from reg in ((new Acceso()).Leer(Sql[3], new Hashtable())).Tables[0].AsEnumerable()
                       select new TipoControl
                       {
                           Id= reg.Field<int>("idtipocontrol"),
                           Nombre = reg.Field<string>("nombre")
                       }).ToList<TipoControl>();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return res;
        }

    }
}

