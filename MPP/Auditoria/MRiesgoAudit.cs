using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Auditoria;
using AccesoDatos;
using System.Collections;
using Mapeo.Seguridad;
using Mapeo.DefMatrizControl;
using System.Data;
using Entidades.Seguridad;
using Servicios.Seguridad;

namespace Mapeo.Auditoria
{
    public class MRiesgoAudit
    {

        public void RestoreRiesgo(RiesgoAudit obj)
        {
            Hashtable param = new Hashtable();
            
            try
            {
                
                param.Add("@idRiesgoaudit", obj.Id);
                param.Add("@idusuario", Sesion.Instancia.Usuario.IdUsuario);
                
                (new Acceso()).Escribir("restoreRiesgo", param);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public IList<RiesgoAudit> GetRiesgosAudit()
        {

            Hashtable param = new Hashtable();

            try
            {
                var lAreaNegocio = (new MAreaNegocio()).Leer();
                var lClasificacionRiesgo = (new MClasificacionRiesgo()).Leer();
                var lMatrizControl = (new MMatrizControl()).Leer();
                var lUsuario = (new MUsuario()).Leer();
                var lEstadoRiesgo = (new MEstadoRiesgo()).Leer();

                var res = (from reg in ((new Acceso()).Leer("getRiesgosAudit", new Hashtable())).Tables[0].AsEnumerable()
                            select new RiesgoAudit
                            {
                                Id = reg.Field<int>("idriesgoaudit"),
                                IdRiesgo = reg.Field<int>("idriesgo"),
                                Nombre = reg.Field<string>("nombre"),
                                AreaNegocio = lAreaNegocio.FirstOrDefault(x => x.Id == reg.Field<int>("idareanegocio")),
                                Clasificacion = lClasificacionRiesgo.FirstOrDefault(x => x.Id == reg.Field<int>("idclasificacionriesgo")),
                                MatrizControl = lMatrizControl.FirstOrDefault(x => x.Id == reg.Field<int>("idmatrizcontrol")),
                                EstadoRiesgo = lEstadoRiesgo.FirstOrDefault(x => x.Id == reg.Field<int>("idestadoriesgo")),
                                Observacion = reg.Field<string>("observacion"),
                                Comentario = reg.Field<string>("comentario"),
                                TipoTransaccion = reg.Field<string>("tipotransaccion"),
                                UsuarioTRX = lUsuario.FirstOrDefault(x => x.IdUsuario == reg.Field<int>("idusuario")),
                                Fecha = reg.Field<DateTime>("fecha")
                            }).ToList<RiesgoAudit>();

                return res;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
