using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Seguridad;
using Servicios.Seguridad;
using AccesoDatos;
using System.Collections;
using System.Data;
using System.Security.Claims;

namespace Mapeo.Seguridad
{
    public class MPrivilegio
    {
        private string[] Sql = { "addPrivilegio", "updPrivilegio", "delPrivilegio", "getUsuarioPrivilegios", "getPrivilegios", "getPermisos", "getRoles" };
        private string[] SqlHijo = { "addPrivilegioHijo", "delPrivilegioHijo"};
        private string[] SqlPrivUsuario = { "addUsuarioPrivilegio", "delUsuarioPrivilegio" };

        public void Operacion(Privilegio obj, int ope)
        {

            Hashtable param = new Hashtable();

            try
            {
                if (ope > 0)
                {
                    param.Add("@idPrivilegio", obj.Id);
                }

                if (ope < 2)
                {
                    param.Add("@nombre", obj.Nombre);

                    if (obj.Llave != Llave.NoDefinida)
                        param.Add("@llave", obj.Llave.ToString());
                    else
                        param.Add("@llave", DBNull.Value);
                }

                (new Acceso()).Escribir(Sql[ope], param);

                //if (!(obj.Privilegios.Count > 0))
                //{
                //    foreach (var item in obj.Privilegios)
                //    {
                //        if (padre.Nombre != "")
                //        {
                //            param = new Hashtable();
                //            param.Add("@nombrePadre", padre.Nombre);
                //            param.Add("@nombreHijo", obj.Nombre);

                //            (new Acceso()).Escribir(Sql[4], param);
                //        }
                //    }
                    
                //}
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


        }

        public void OperacionHijo(Privilegio padre, Privilegio hijo, int ope)
        {
            Hashtable param = new Hashtable();

            try
            {
                param.Add("@idPrivilegioPadre", padre.Id);
                param.Add("@idPrivilegioHijo", hijo.Id);
                
                (new Acceso()).Escribir(SqlHijo[ope], param);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public void OperacionPrivlegioUsuario(Usuario usr, Privilegio priv, int ope)
        {
            Hashtable param = new Hashtable();

            try
            {
                param.Add("@idUsuario", usr.IdUsuario);
                param.Add("@idPrivilegio", priv.Id);

                (new Acceso()).Escribir(SqlPrivUsuario[ope], param);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public List<Privilegio> GetPrivilegios(Usuario usr)
        {
            Hashtable param = new Hashtable();
            List<Privilegio> privilegios = new List<Privilegio>();
            Privilegio priv;

            try
            {
                if (usr != null)
                    param.Add("@idUsuario", usr.IdUsuario);
                else
                    param.Add("@idUsuario", DBNull.Value);

                var res = (from reg in ((new Acceso()).Leer(Sql[3], param)).Tables[0].AsEnumerable()
                           select new
                           {
                               Id = reg.Field<int>("idprivilegio"),
                               Nombre = reg.Field<string>("nombre"),
                               Llave = reg.Field<string>("llave"),
                               IdPrivilegioPadre = reg.Field<int>("idprivilegio_padre")
                           }).ToList() ;

                foreach (var item in res.Where(x => !(x.IdPrivilegioPadre > 0)))
                {

                    if (string.IsNullOrEmpty(item.Llave))
                    {

                        priv = FindPrivilegios(item, res.Where(x => (x.IdPrivilegioPadre > 0)));
                    }
                    else
                    {
                        priv = new Permiso();
                        priv.Id = item.Id;
                        priv.Nombre = item.Nombre;
                        priv.Llave = (Llave)Enum.Parse(typeof(Llave), item.Llave);
                    }

                    privilegios.Add(priv);

                }

                return privilegios;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            
        }

        public List<Privilegio> GetPrivilegios()
        {
            Hashtable param = new Hashtable();
            List<Privilegio> privilegios = new List<Privilegio>();
            Privilegio priv = new Permiso();

            try
            {
                
                var res = (from reg in ((new Acceso()).Leer(Sql[4], param)).Tables[0].AsEnumerable()
                           select new
                           {
                               Id = reg.Field<int>("idprivilegio"),
                               Nombre = reg.Field<string>("nombre"),
                               Llave = reg.Field<string>("llave"),
                               IdPrivilegioPadre = reg.Field<int>("idprivilegio_padre")
                           }).ToList();

                foreach (var item in res.Where(x => !(x.IdPrivilegioPadre > 0)))
                {
                    priv = FindPrivilegios(item, res.Where(x => (x.IdPrivilegioPadre > 0)));

                    privilegios.Add(priv);

                }

                return privilegios;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public Rol FindPrivilegios(dynamic padre, IEnumerable<dynamic> listaPrivilegios)
        {
            Privilegio priv;
            Rol rol = new Rol();
            rol.Id = padre.Id;
            rol.Nombre = padre.Nombre;

            try
            {
                foreach (var item in listaPrivilegios.Where(x =>(x.IdPrivilegioPadre == padre.Id)))
                {
                    priv = rol.BuscarPrivilegio(item.Id);

                    if (priv == null)
                    {
                        if (string.IsNullOrEmpty(item.Llave))
                        {
                            priv = FindPrivilegios(item, listaPrivilegios);
                        }
                        else
                        {
                            priv = new Permiso();
                            priv.Id = item.Id;
                            priv.Nombre = item.Nombre;
                            priv.Llave = (Llave)Enum.Parse(typeof(Llave), item.Llave);
                        }
                        rol.AgregarPrivilegio(priv);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return rol;
        }

        public List<Privilegio> GetPermisos()
        {
            Hashtable param = new Hashtable();

            try
            {
                var permisos = (from reg in ((new Acceso()).Leer(Sql[5], param)).Tables[0].AsEnumerable()
                           select new Permiso
                           {
                               Id = reg.Field<int>("idprivilegio"),
                               Nombre = reg.Field<string>("nombre"),
                               Llave = (Llave) Enum.Parse(typeof(Llave),reg.Field<string>("llave"))
                           }).ToList<Privilegio>();

                return permisos;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public List<Privilegio> GetRoles()
        {
            Hashtable param = new Hashtable();

            try
            {
                var permisos = (from reg in ((new Acceso()).Leer(Sql[6], param)).Tables[0].AsEnumerable()
                                select new Rol
                                {
                                    Id = reg.Field<int>("idprivilegio"),
                                    Nombre = reg.Field<string>("nombre")
                                }).ToList<Privilegio>();

                return permisos;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
