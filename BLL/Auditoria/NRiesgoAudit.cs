using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Auditoria;
using Mapeo.Auditoria;

namespace Negocio.Auditoria
{
    public class NRiesgoAudit
    {
        public void RestoreRiesgo(RiesgoAudit obj)
        {
            (new MRiesgoAudit()).RestoreRiesgo(obj);
        }

        public IList<RiesgoAudit> GetRiesgosAudit(RiesgoAudit riesgo)
        {
            IList<RiesgoAudit> riesgos = (new MRiesgoAudit()).GetRiesgosAudit();

            if (riesgo.IdRiesgo > 0)
            {
                riesgos = riesgos.Where(x => x.IdRiesgo == riesgo.IdRiesgo).ToList<RiesgoAudit>();
            }

            if (riesgo.Nombre != null)
            {
                riesgos = riesgos.Where(x => x.Nombre.Contains(riesgo.Nombre)).ToList<RiesgoAudit>();
            }

            if (riesgo.Clasificacion != null)
            {
                riesgos = riesgos.Where(x => x.Clasificacion.Id == riesgo.Clasificacion.Id).ToList<RiesgoAudit>();
            }

            if (riesgo.AreaNegocio != null)
            {
                riesgos = riesgos.Where(x => x.AreaNegocio.Id == riesgo.AreaNegocio.Id).ToList<RiesgoAudit>();
            }

            if (riesgo.MatrizControl != null)
            {
                riesgos = riesgos.Where(x => x.MatrizControl.Id == riesgo.MatrizControl.Id).ToList<RiesgoAudit>();
            }

            return riesgos;
        }

        public bool IsAlive(RiesgoAudit obj)
        {
            bool res = true;

            if (GetRiesgosAudit(obj).Where(x => x.TipoTransaccion == "D").Count() > 0)
            {
                res = false;
            }
            
            return res;
        }
    }
}
