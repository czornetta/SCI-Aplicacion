using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Seguridad
{
    public class Permiso : Privilegio
    {
        public override IList<Privilegio> Privilegios
        {
            get
            {
                return new List<Privilegio>();
            }

        }

        public override void AgregarPrivilegio(Privilegio c)
        {
            
        }

        public override void BorrarPrivilegio(Privilegio c)
        {
            
        }
    }
}
