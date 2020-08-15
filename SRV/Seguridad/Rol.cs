using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad
{
    public class Rol : Privilegio
    {
        private IList<Privilegio> _Privilegios;

        public override IList<Privilegio> Privilegios
        {
            get
            {
                return _Privilegios.ToArray();
            }

        }

        public Rol()
        {
            _Privilegios = new List<Privilegio>();
        }

        public override void AgregarPrivilegio(Privilegio c)
        {
            _Privilegios.Add(c);
        }

        public override void BorrarPrivilegio(Privilegio c)
        {
            _Privilegios.Remove(c);
        }

        public Privilegio BuscarPrivilegio(int id)
        {
            return _Privilegios.Where(u => u.Id == id).FirstOrDefault();

        }

        public Privilegio BuscarPrivilegio(string nombre)
        {
            return _Privilegios.Where(u => u.Nombre.Equals(nombre) ).FirstOrDefault();

        }
    }
}
