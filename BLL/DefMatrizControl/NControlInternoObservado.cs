using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.DefMatrizControl;
using Mapeo.DefMatrizControl;
using Entidades.Seguridad;
using Servicios.Seguridad;

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
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("ControlInternoObservado");

                if (obj.Nombre == null)
                    throw new AtributoNotNullException("Nombre");

                if (obj.Descripcion == null)
                    throw new AtributoNotNullException("Descripcion");

                if (obj.Tipo == null)
                    throw new AtributoNotNullException("Tipo");

                if (obj.Periodicidad == null)
                    throw new AtributoNotNullException("Periodicidad");


                var estado = (new NEstadoControlInterno()).GetEstadosControlInterno().FirstOrDefault(x => x.Clase == typeof(ControlInternoPropuesto).ToString());
                (new MControlInterno()).SetEstadoControlInterno(obj, estado);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void CancelarControlInterno(ControlInternoObservado obj)
        {
            var estado = (new NEstadoControlInterno()).GetEstadosControlInterno().FirstOrDefault(x => x.Clase == typeof(ControlInternoCancelado).ToString());
            (new MControlInterno()).SetEstadoControlInterno(obj, estado);
        }
    }
}
