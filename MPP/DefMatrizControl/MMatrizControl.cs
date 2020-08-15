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
    public class MMatrizControl
    {
        private string[] Sql = { "addMatrizControl", "updMatrizControl", "delMatrizControl", "getMatricesControl", "getMatrizControlResumen" };

        public void Operacion(MatrizControl obj, int ope)
        {

            Hashtable param = new Hashtable();

            try
            {
                if (ope > 0)
                {
                    param.Add("@idMatrizControl", obj.Id);
                }

                if (ope < 2)
                {
                    param.Add("@periodo", obj.Periodo);
                    param.Add("@idestado", obj.Estado.Id);
                }

                (new Acceso()).Escribir(Sql[ope], param);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }

        public IList<MatrizControl> Leer()
        {
            List<MatrizControl> res = new List<MatrizControl>();

            try
            {
                var lEstadosMatrizControl = (new MEstadoMatrizControl()).Leer();

                res = (from reg in ((new Acceso()).Leer(Sql[3], new Hashtable())).Tables[0].AsEnumerable()
                       select new MatrizControl
                       {
                           Id= reg.Field<int>("idMatrizControl"),
                           Periodo = reg.Field<int>("periodo"),
                           Estado = lEstadosMatrizControl.FirstOrDefault(x => x.Id == reg.Field<int>("idestado"))
                       }).ToList<MatrizControl>();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return res;
        }

        //public IEnumerable LeerRiesgosResumenAreaNegocio(MatrizControl matrizControl)
        //{
        //    Hashtable param = new Hashtable();

        //    try
        //    {
        //        IList<Riesgo> riesgos = (new MRiesgo()).Leer(matrizControl,0);


        //        var resumen = (from p in riesgos
        //                       group p by p.AreaNegocio into grupo
        //                       select new
        //                       {
        //                           AreaNeocio = grupo.Key,
        //                           CantidadRiesgos = grupo.Count()
        //                       }).ToList();

        //        return resumen;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message);
        //    }
        //}

        public IEnumerable LeerMatrizControlResumen(MatrizControl matrizControl)
        {
            Hashtable param = new Hashtable();

            try
            {
                var lAreaNegocio = (new MAreaNegocio()).Leer();

                if (matrizControl != null)
                    param.Add("@idmatrizcontrol", matrizControl.Id);
                else
                    param.Add("@idmatrizcontrol", DBNull.Value);

                var res = (from reg in ((new Acceso()).Leer(Sql[4], param)).Tables[0].AsEnumerable()
                       select new 
                       {
                           AreaNegocio = lAreaNegocio.FirstOrDefault(x => x.Id == reg.Field<int>("idareanegocio")),
                           Riesgos = reg.Field<int>("riesgos"),
                           ControlesInternos = reg.Field<int>("controlesinternos")
                       }).ToList();

                return res;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}

