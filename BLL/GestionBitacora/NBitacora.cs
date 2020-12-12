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
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("Bitacora");

                if (obj.Usuario == null)
                    throw new AtributoNotNullException("Usuario");

                if (obj.Fecha == null)
                    throw new AtributoNotNullException("Fecha");

                if (obj.Descripcion == null)
                    throw new AtributoNotNullException("Descripcion");

                if (obj.Tipo == null)
                    throw new AtributoNotNullException("Tipo");

                (new MBitacora()).AgregarRegistro(obj);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            

        }

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
