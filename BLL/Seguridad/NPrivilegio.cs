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
            (new MPrivilegio()).Operacion(obj,0);
        }

        public void ModificarPrivilegio(Privilegio obj)
        {
            (new MPrivilegio()).Operacion(obj,1);
        }

        public void BorrarPrivilegio(Privilegio obj)
        {
            (new MPrivilegio()).Operacion(obj,2);
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

            foreach (var item in padre.Privilegios)
            {
                if (item.Id == hijo.Id)
                {
                    res = true;
                    break;
                }

                if(item.Privilegios.Count()>0)
                {
                    res = EsPrivilegioPadre(item, hijo);

                    if (res)
                    {
                        break;
                    }
                }
            }

            return res;
        }

        public void AgregarPrivilegioHijo(Privilegio obj, Privilegio priv)
        {
            (new MPrivilegio()).OperacionHijo(obj,priv, 0);
        }

        public void BorrarPrivilegioHijo(Privilegio obj, Privilegio priv)
        {
            (new MPrivilegio()).OperacionHijo(obj,priv, 1);
        }

        public void AgregarPrivilegioUsuario(Usuario obj, Privilegio priv)
        {
            (new MPrivilegio()).OperacionPrivlegioUsuario(obj, priv, 0);
        }

        public void BorrarPrivilegioUsuario(Usuario obj, Privilegio priv)
        {
            (new MPrivilegio()).OperacionPrivlegioUsuario(obj, priv, 1);
        }
    }
}
