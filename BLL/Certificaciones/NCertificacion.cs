using Mapeo.Certificaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Certificaciones;
using Entidades.DefMatrizControl;

namespace Negocio.Certificaciones
{
    public class NCertificacion
    {
        public void AddCertificacion(Certificacion obj)
        {
            (new MCertificacion()).Operacion(obj, 0);
        }

        public void AceptarExcepcion(Certificacion obj)
        {
            obj.Excepcion.Estado = new EstadoExcepcion { Id = 1 };
            (new MCertificacion()).UpdateExcepcion(obj);
        }

        public void RechazarExcepcion(Certificacion obj)
        {
            obj.Resultado = new ResultadoCertificacion { Id = 3 };
            obj.Excepcion.Estado = new EstadoExcepcion { Id = 3 };
            (new MCertificacion()).Operacion(obj, 1);
        }

        public List<Certificacion> GetCertificaciones(ControlInternoAceptado obj)
        {
            return (new MCertificacion()).GetCertificaciones(obj);
        }

        public List<ResultadoCertificacion> GetResultadosCertificaciones()
        {
            return (new MCertificacion()).GetResultadosCertificaciones();
        }
    }
}
