using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Seguridad;
using Entidades.GestionBitacora;
using AccesoDatos;
using System.Collections;
using System.Data;
using Mapeo.Seguridad;

namespace Mapeo.GestionBitacora
{
    public class MBitacora
    {
        private string[] Sql = { "addBitacora", "getBitacora", "getTiposRegistro" };

        public void AgregarRegistro(Bitacora obj) 
        {
            Hashtable param = new Hashtable();

            try
            {
                param.Add("@idusuario", obj.Usuario.IdUsuario);
                param.Add("@fecha", obj.Fecha);
                param.Add("@tipo_registro", obj.Tipo);
                param.Add("@descripcion", obj.Descripcion);

                (new Acceso()).Escribir(Sql[0], param);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public IList<Bitacora> LeerBitacora(Usuario usuario, string tipo, DateTime fDesde, DateTime fHasta)
        {
            List<Bitacora> registros;
            Hashtable param = new Hashtable();
            
            try
            {
                if (usuario != null)
                    param.Add("@idUsuario", usuario.IdUsuario);
                else
                    param.Add("@idUsuario", DBNull.Value);

                if (tipo != null)
                    param.Add("@tipo_registro", tipo);
                else
                    param.Add("@tipo_registro", DBNull.Value);

                if (fDesde != null)
                    param.Add("@fecha_desde", fDesde);
                else
                    param.Add("@fecha_desde", DBNull.Value);

                if (fHasta != null)
                    param.Add("@fecha_hasta", fHasta);
                else
                    param.Add("@fecha_hasta", DBNull.Value);

                var lUsuario = (new MUsuario()).Leer();

                if (tipo =="Error")
                {
                    registros = (from reg in ((new Acceso()).Leer(Sql[1], param)).Tables[0].AsEnumerable()
                                 select new Error
                                 {
                                     Usuario = lUsuario.FirstOrDefault(x => x.IdUsuario == reg.Field<int>("idusuario")),
                                     Fecha = reg.Field<DateTime>("fecha"),
                                     Descripcion = reg.Field<string>("descripcion")
                                 }).ToList<Bitacora>();
                   
                }
                else
                    registros = (from reg in ((new Acceso()).Leer(Sql[1], param)).Tables[0].AsEnumerable()
                                 select new Evento
                                 {
                                     Usuario = lUsuario.FirstOrDefault(x => x.IdUsuario == reg.Field<int>("idusuario")),
                                     Fecha = reg.Field<DateTime>("fecha"),
                                     Descripcion = reg.Field<string>("descripcion")
                                 }).ToList<Bitacora>();

                return registros;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        public IList LeerTiposRegistro()
        {

            try
            {

                var res = (from reg in ((new Acceso()).Leer(Sql[2], new Hashtable())).Tables[0].AsEnumerable()
                           select reg.Field<string>("tipo_registro")
                           ).ToList();

                return res;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

    }
}
