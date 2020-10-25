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
using Entidades.Seguridad;
using Servicios.Seguridad;

namespace Mapeo.DefMatrizControl
{
    public class MRiesgo
    {
        private string[] Sql = { "addRiesgo", "updRiesgo", "delRiesgo", "getRiesgos" };

        public void Operacion(RiesgoPropuesto obj, int ope)
        {

            Hashtable param = new Hashtable();
            var lEstadoRiesgo = (new MEstadoRiesgo()).Leer();

            try
            {
                switch (ope)
                {
                    case 0:
                        param.Add("@idmatrizcontrol", obj.MatrizControl.Id);
                        param.Add("@idareanegocio", obj.AreaNegocio.Id);
                        param.Add("@idestadoriesgo", lEstadoRiesgo.FirstOrDefault(x => x.Clase == obj.GetType().ToString()).Id);
                        param.Add("@nombre", obj.Nombre);
                        param.Add("@idclasificacionriesgo", obj.Clasificacion.Id);
                        param.Add("@observacion", DBNull.Value);
                        param.Add("@comentario", DBNull.Value);
                        param.Add("@idusuario", Sesion.Instancia.Usuario.IdUsuario);
                        break;

                    case 1:
                        param.Add("@idRiesgo", obj.Id);
                        param.Add("@idestadoriesgo", DBNull.Value);
                        param.Add("@nombre", obj.Nombre);
                        param.Add("@idclasificacionriesgo", obj.Clasificacion.Id);
                        if (obj.Observacion == null)
                        {
                            param.Add("@observacion", DBNull.Value);
                        }
                        else
                        {
                            param.Add("@observacion", obj.Observacion);
                        }

                        if (obj.Comentario == null)
                        {
                            param.Add("@comentario", DBNull.Value);
                        }
                        else
                        {
                            param.Add("@comentario", obj.Comentario);
                        }
                        param.Add("@idusuario", Sesion.Instancia.Usuario.IdUsuario);
                        break;
                    case 2:
                        param.Add("@idRiesgo", obj.Id);
                        param.Add("@idusuario", Sesion.Instancia.Usuario.IdUsuario);
                        break;
                    default:
                        break;
                }

                (new Acceso()).Escribir(Sql[ope], param);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }

        public void SetEstadoRiesgo(Riesgo obj, EstadoRiesgo estado)
        {

            Hashtable param = new Hashtable();

            try
            {
                param.Add("@idRiesgo", obj.Id);
                param.Add("@nombre", obj.Nombre);
                param.Add("@idclasificacionriesgo", obj.Clasificacion.Id);
                param.Add("@idestadoriesgo", estado.Id);
                param.Add("@idusuario", Sesion.Instancia.Usuario.IdUsuario);

                if (obj.Observacion == null)
                {
                    param.Add("@observacion", DBNull.Value);
                }
                else
                {
                    param.Add("@observacion", obj.Observacion);
                }

                if (obj.Comentario == null)
                {
                    param.Add("@comentario", DBNull.Value);
                }
                else
                {
                    param.Add("@comentario", obj.Comentario);
                }

                

                (new Acceso()).Escribir(Sql[1], param);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public IList Leer(MatrizControl matrizControl, EstadoRiesgo estado)
        {

            Hashtable param = new Hashtable();

            try
            {
                var lAreaNegocio = (new MAreaNegocio()).Leer();
                var lClasificacionRiesgo = (new MClasificacionRiesgo()).Leer();

                if (matrizControl != null)
                    param.Add("@idmatrizcontrol", matrizControl.Id);
                else
                    param.Add("@idmatrizcontrol", DBNull.Value);

                var res = (from reg in ((new Acceso()).Leer(Sql[3], new Hashtable())).Tables[0].AsEnumerable()
                       where reg.Field<int>("idestadoriesgo") == estado.Id
                           select new
                       {
                           Id = reg.Field<int>("idriesgo"),
                           Nombre = reg.Field<string>("nombre"),
                           AreaNegocio = lAreaNegocio.FirstOrDefault(x => x.Id == reg.Field<int>("idareanegocio")),
                           Clasificacion = lClasificacionRiesgo.FirstOrDefault(x => x.Id == reg.Field<int>("idclasificacionriesgo")),
                           Observacion = reg.Field<string>("observacion"),
                           Comentario = reg.Field<string>("comentario")
                       }).ToList();

                return res;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        //public IList<Riesgo> LeerRiesgosNoAceptados(MatrizControl matrizControl)
        //{
        //    List<Riesgo> res = new List<Riesgo>();
        //    Hashtable param = new Hashtable();

        //    try
        //    {
        //        var lAreaNegocio = (new MAreaNegocio()).Leer();
        //        var lClasificacionRiesgo = (new MClasificacionRiesgo()).Leer();
        //        var lEstadoRiesgo = (new MEstadoRiesgo()).Leer();

        //        if (matrizControl != null)
        //            param.Add("@idmatrizcontrol", matrizControl.Id);
        //        else
        //            param.Add("@idmatrizcontrol", DBNull.Value);

        //        res = (from reg in ((new Acceso()).Leer(Sql[3], new Hashtable())).Tables[0].AsEnumerable()
        //               where reg.Field<int>("idestado") != 3
        //               select new Riesgo
        //               (
        //                   reg.Field<int>("idriesgo"),
        //                   reg.Field<string>("nombre"),
        //                   matrizControl,
        //                   lAreaNegocio.FirstOrDefault(x => x.Id == reg.Field<int>("idareanegocio")),
        //                   lClasificacionRiesgo.FirstOrDefault(x => x.Id == reg.Field<int>("idclasificacionriesgo")),
        //                   reg.Field<string>("observacion"),
        //                   reg.Field<string>("comentario"),
        //                   lEstadoRiesgo.FirstOrDefault(x => x.Id == reg.Field<int>("idestadoriesgo"))
        //               )).ToList<Riesgo>();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message);
        //    }

        //    return res;
        //}

        //public IList<Riesgo> LeerRiesgosObservados(MatrizControl matrizControl)
        //{
        //    List<Riesgo> res = new List<Riesgo>();
        //    Hashtable param = new Hashtable();

        //    try
        //    {
        //        var lAreaNegocio = (new MAreaNegocio()).Leer();
        //        var lClasificacionRiesgo = (new MClasificacionRiesgo()).Leer();
        //        var lEstadoRiesgo = (new MEstadoRiesgo()).Leer();

        //        if (matrizControl != null)
        //            param.Add("@idmatrizcontrol", matrizControl.Id);
        //        else
        //            param.Add("@idmatrizcontrol", DBNull.Value);

        //        res = (from reg in ((new Acceso()).Leer(Sql[3], new Hashtable())).Tables[0].AsEnumerable()
        //               where reg.Field<int>("idestadoriesgo") == 2
        //               select new Riesgo
        //               (
        //                   reg.Field<int>("idriesgo"),
        //                   reg.Field<string>("nombre"),
        //                   matrizControl,
        //                   lAreaNegocio.FirstOrDefault(x => x.Id == reg.Field<int>("idareanegocio")),
        //                   lClasificacionRiesgo.FirstOrDefault(x => x.Id == reg.Field<int>("idclasificacionriesgo")),
        //                   reg.Field<string>("observacion"),
        //                   reg.Field<string>("comentario"),
        //                   lEstadoRiesgo.FirstOrDefault(x => x.Id == reg.Field<int>("idestadoriesgo"))
        //               )).ToList<Riesgo>();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message);
        //    }

        //    return res;
        //}

        //public IList<Riesgo> LeerRiesgosPropuestos(MatrizControl matrizControl)
        //{
        //    List<Riesgo> res = new List<Riesgo>();
        //    Hashtable param = new Hashtable();

        //    try
        //    {
        //        var lAreaNegocio = (new MAreaNegocio()).Leer();
        //        var lClasificacionRiesgo = (new MClasificacionRiesgo()).Leer();
        //        var lEstadoRiesgo = (new MEstadoRiesgo()).Leer();

        //        if (matrizControl != null)
        //            param.Add("@idmatrizcontrol", matrizControl.Id);
        //        else
        //            param.Add("@idmatrizcontrol", DBNull.Value);

        //        res = (from reg in ((new Acceso()).Leer(Sql[3], new Hashtable())).Tables[0].AsEnumerable()
        //               where reg.Field<int>("idestadoriesgo") == 1
        //               select new Riesgo
        //               (
        //                   reg.Field<int>("idriesgo"),
        //                   reg.Field<string>("nombre"),
        //                   matrizControl,
        //                   lAreaNegocio.FirstOrDefault(x => x.Id == reg.Field<int>("idareanegocio")),
        //                   lClasificacionRiesgo.FirstOrDefault(x => x.Id == reg.Field<int>("idclasificacionriesgo")),
        //                   reg.Field<string>("observacion"),
        //                   reg.Field<string>("comentario"),
        //                   lEstadoRiesgo.FirstOrDefault(x => x.Id == reg.Field<int>("idestadoriesgo"))
        //               )).ToList<Riesgo>();
        //    }
        //    catch (Exception ex)
        //    {

        //        throw new Exception(ex.Message);
        //    }

        //    return res;
        //}
    }
}
