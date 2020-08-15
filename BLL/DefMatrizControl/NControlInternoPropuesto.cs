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
    public class NControlInternoPropuesto: NControlInterno
    {
        public void AgregarControlInterno(ControlInternoPropuesto obj)
        {
            (new MControlInterno()).Operacion(obj, 0);
        }

        public void ModificarControlInterno(ControlInternoPropuesto obj)
        {
            (new MControlInterno()).Operacion(obj, 1);
        }

        public void BorrarControlInterno(ControlInternoPropuesto obj)
        {
            (new MControlInterno()).Operacion(obj, 2);
        }

        //public override IList<ControlInterno> GetControlesInternos()
        //{
        //    return (new MControlInterno()).Leer(null);
        //}

        public override IList<ControlInterno> GetControlesInternos(Riesgo riesgo)
        {
            List<ControlInterno> controles = new List<ControlInterno>();
            ControlInternoPropuesto control;

            var estado = (new MEstadoControlInterno()).Leer().FirstOrDefault(x => x.Clase == typeof(ControlInternoPropuesto).ToString());


            foreach (var r in (new MControlInterno()).Leer(riesgo, estado))
            {

                control = new ControlInternoPropuesto((int)r.GetType().GetProperty("Id").GetValue(r)
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

        public void AceptarControlInterno(ControlInternoPropuesto obj)
        {
            var estado = (new NEstadoControlInterno()).GetEstadosControlInterno().FirstOrDefault(x => x.Clase == typeof(ControlInternoAceptado).ToString());
            (new MControlInterno()).SetEstadoControlInterno(obj, estado);
        }

        public void ObservarControlInterno(ControlInternoPropuesto obj)
        {
            var estado = (new NEstadoControlInterno()).GetEstadosControlInterno().FirstOrDefault(x => x.Clase == typeof(ControlInternoObservado).ToString());
            (new MControlInterno()).SetEstadoControlInterno(obj, estado);
        }
    }
}
