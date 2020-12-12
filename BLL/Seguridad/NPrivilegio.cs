using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Seguridad;
using Mapeo.Seguridad;
using Servicios.Seguridad;

namespace Negocio.Seguridad
{
    public class NPrivilegio
    {
        public void AgregarPrivilegio(Privilegio obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("Privilegio");

                if (obj.Nombre == null)
                    throw new AtributoNotNullException("Nombre");

                (new MPrivilegio()).Operacion(obj, 0);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void ModificarPrivilegio(Privilegio obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("Privilegio");

                if (!(obj.Id > 0))
                    throw new AtributoNotNullException("Id");

                if (obj.Nombre == null)
                    throw new AtributoNotNullException("Nombre");

                (new MPrivilegio()).Operacion(obj, 1);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void BorrarPrivilegio(Privilegio obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("Privilegio");

                if (!(obj.Id > 0))
                    throw new AtributoNotNullException("Id");

                (new MPrivilegio()).Operacion(obj, 2);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public List<Privilegio> GetPrivilegios(Usuario usr)
        {
            return (new MPrivilegio()).GetPrivilegios(usr);
        }

        public List<Privilegio> GetPrivilegios()
        {
            return (new MPrivilegio()).GetPrivilegios();
        }

        public List<Privilegio> GetPermisos()
        {
            return (new MPrivilegio()).GetPermisos();
        }

        public List<Privilegio> GetRoles()
        {
            return (new MPrivilegio()).GetRoles();
        }

        public bool EsPrivilegioPadre(Privilegio padre, Privilegio hijo)
        {
            bool res = false;
            try
            {
                if (padre == null)
                    throw new AtributoNotNullException("Privilegio Padre");

                if (hijo == null)
                    throw new AtributoNotNullException("Privilegio Hijo");

                foreach (var item in padre.Privilegios)
                {
                    if (item.Id == hijo.Id)
                    {
                        res = true;
                        break;
                    }

                    if (item.Privilegios.Count() > 0)
                    {
                        res = EsPrivilegioPadre(item, hijo);

                        if (res)
                        {
                            break;
                        }
                    }
                }
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
            return res;
        }

        public void AgregarPrivilegioHijo(Privilegio obj, Privilegio priv)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("Privilegio Padre");

                if (priv == null)
                    throw new AtributoNotNullException("Privilegio Hijo");

                (new MPrivilegio()).OperacionHijo(obj, priv, 0);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void BorrarPrivilegioHijo(Privilegio obj, Privilegio priv)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("Privilegio Padre");

                if (priv == null)
                    throw new AtributoNotNullException("Privilegio Hijo");

                (new MPrivilegio()).OperacionHijo(obj, priv, 1);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void AgregarPrivilegioUsuario(Usuario obj, Privilegio priv)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("Usuario");

                if (priv == null)
                    throw new AtributoNotNullException("Privilegio");

                (new MPrivilegio()).OperacionPrivlegioUsuario(obj, priv, 0);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
        }

        public void BorrarPrivilegioUsuario(Usuario obj, Privilegio priv)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("Usuario");

                if (priv == null)
                    throw new AtributoNotNullException("Privilegio");

                (new MPrivilegio()).OperacionPrivlegioUsuario(obj, priv, 1);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
