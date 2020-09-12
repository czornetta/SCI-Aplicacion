using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Seguridad;
using Entidades.GestionBitacora;
using Mapeo.GestionBitacora;
using Servicios.Seguridad;

namespace Negocio.GestionBitacora
{
    public class NBitacora
    {
        public void AgregarRegistro(Bitacora obj)
        {

            (new MBitacora()).AgregarRegistro(obj);

        }

        //public IEnumerable Registros()
        //{
        //    return (new MBitacora()).LeerBitacora();
            
        //}

        public IList<Bitacora> Registros(Usuario usuario, string tipo, DateTime fDesde, DateTime fHasta)
        {
            return (new MBitacora()).LeerBitacora(usuario, tipo, fDesde, fHasta);

        }

        public IList GetTiposRegistro()
        {
            return (new MBitacora()).LeerTiposRegistro();

        }
    }
}
