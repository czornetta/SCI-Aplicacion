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
    public class NControlInternoPropuesto: NControlInterno
    {
        public void AgregarControlInterno(ControlInternoPropuesto obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("ControlInternoPropuesto");

                if (obj.Nombre == null)
                    throw new AtributoNotNullException("Nombre");

                if (obj.Descripcion == null)
                    throw new AtributoNotNullException("Descripcion");

                if (obj.Tipo == null)
                    throw new AtributoNotNullException("Tipo");

                if (obj.Periodicidad == null)
                    throw new AtributoNotNullException("Periodicidad");

                if (obj.Riesgo == null)
                    throw new AtributoNotNullException("Riesgo");

                (new MControlInterno()).Operacion(obj, 0);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void ModificarControlInterno(ControlInternoPropuesto obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("ControlInternoPropuesto");

                if (obj.Nombre == null)
                    throw new AtributoNotNullException("Nombre");

                if (obj.Descripcion == null)
                    throw new AtributoNotNullException("Descripcion");

                if (obj.Tipo == null)
                    throw new AtributoNotNullException("Tipo");

                if (obj.Periodicidad == null)
                    throw new AtributoNotNullException("Periodicidad");

                if (obj.Riesgo == null)
                    throw new AtributoNotNullException("Riesgo");

                (new MControlInterno()).Operacion(obj, 1);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void BorrarControlInterno(ControlInternoPropuesto obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("ControlInternoPropuesto");

                
                (new MControlInterno()).Operacion(obj, 2);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

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
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("ControlInternoPropuesto");

                if (obj.Observacion == null)
                    throw new AtributoNotNullException("Observacion");

                var estado = (new NEstadoControlInterno()).GetEstadosControlInterno().FirstOrDefault(x => x.Clase == typeof(ControlInternoObservado).ToString());
                (new MControlInterno()).SetEstadoControlInterno(obj, estado);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }
    }
}
