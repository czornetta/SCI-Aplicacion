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
    public class NControlInternoAceptado: NControlInterno
    {
        

        public override IList<ControlInterno> GetControlesInternos(Riesgo riesgo)
        {
            List<ControlInterno> controles = new List<ControlInterno>();
            ControlInternoAceptado control;

            var estado = (new MEstadoControlInterno()).Leer().FirstOrDefault(x => x.Clase == typeof(ControlInternoAceptado).ToString());


            foreach (var r in (new MControlInterno()).Leer(riesgo, estado))
            {

                control = new ControlInternoAceptado((int)r.GetType().GetProperty("Id").GetValue(r)
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
    }
}
