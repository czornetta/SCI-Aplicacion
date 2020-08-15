using Entidades.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad
{
    public abstract class Privilegio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Llave Llave { get; set; }

        public abstract IList<Privilegio> Privilegios { get; }
       
        public abstract void AgregarPrivilegio(Privilegio c);
        public abstract void BorrarPrivilegio(Privilegio c);

        public override string ToString()
        {
            return Nombre;
        }
    }
}
