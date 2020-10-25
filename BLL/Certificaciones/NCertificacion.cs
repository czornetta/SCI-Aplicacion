using Mapeo.Certificaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Certificaciones;
using Entidades.DefMatrizControl;
using Negocio.DefMatrizControl;

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
            obj.Excepcion.Estado = new EstadoExcepcion { Id = 2 };
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

        public List<EstadoExcepcion> GetEstadosExcepcion()
        {
            return (new MCertificacion()).GetEstadosExcepcion();
        }

        public List<Certificacion> GetCertificaciones(MatrizControl obj)
        {
            MCertificacion mCertificacion = new MCertificacion();
            List<Certificacion> certificaciones = new List<Certificacion>();

            foreach (var item in (new NMatrizControl()).GetControlesInternos(obj))
            {
                certificaciones.AddRange(mCertificacion.GetCertificaciones((ControlInternoAceptado)item));
            }
            return certificaciones;
        }
    }
}
