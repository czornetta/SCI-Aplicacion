using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.DefMatrizControl;
using Mapeo.DefMatrizControl;
using Entidades.Seguridad;

namespace Negocio.DefMatrizControl
{
    public class NControlInternoObservado: NControlInterno
    {
        public override IList<ControlInterno> GetControlesInternos(Riesgo riesgo)
        {
            List<ControlInterno> controles = new List<ControlInterno>();
            ControlInternoObservado control;

            var estado = (new NEstadoControlInterno()).GetEstadosControlInterno().FirstOrDefault(x => x.Clase == typeof(ControlInternoObservado).ToString());


            foreach (var r in (new MControlInterno()).Leer(riesgo, estado))
            {

                control = new ControlInternoObservado((int)r.GetType().GetProperty("Id").GetValue(r)
                                            , (string)r.GetType().GetProperty("Nombre").GetValue(r)
                                            , (string)r.GetType().GetProperty("Descripcion").GetValue(r)
                                            , riesgo
                                            , (TipoControl)r.GetType().GetProperty("Tipo").GetValue(r)
                                            , (PeriodicidadControl)r.GetType().GetProperty("Periodicidad").GetValue(r)
                                            , (string)r.GetType().GetProperty("Observacion").GetValue(r)
                                            , (string)r.GetType().GetProperty("Comentario").GetValue(r));
                controles.Add(control);
            }

            return controles;
        }

        public void ProponerControlInterno(ControlInternoObservado obj)
        {
            var estado = (new NEstadoControlInterno()).GetEstadosControlInterno().FirstOrDefault(x => x.Clase == typeof(ControlInternoPropuesto).ToString());
            (new MControlInterno()).SetEstadoControlInterno(obj, estado);
        }

        public void CancelarControlInterno(ControlInternoObservado obj)
        {
            var estado = (new NEstadoControlInterno()).GetEstadosControlInterno().FirstOrDefault(x => x.Clase == typeof(ControlInternoCancelado).ToString());
            (new MControlInterno()).SetEstadoControlInterno(obj, estado);
        }
    }
}
