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
    public class NRiesgoAceptado: NRiesgo
    {
        
        public override IList<Riesgo> GetRiesgos(MatrizControl matrizControl)
        {
            List<Riesgo> riesgos = new List<Riesgo>();
            RiesgoAceptado riesgo;
            var estadoRiesgo = (new MEstadoRiesgo()).Leer().FirstOrDefault(x => x.Clase == typeof(RiesgoAceptado).ToString());

            foreach (var r in (new MRiesgo()).Leer(matrizControl, estadoRiesgo))
            {
            
                riesgo = new RiesgoAceptado((int)r.GetType().GetProperty("Id").GetValue(r)
                                            , (string)r.GetType().GetProperty("Nombre").GetValue(r)
                                            , matrizControl
                                            , (AreaNegocio)r.GetType().GetProperty("AreaNegocio").GetValue(r)
                                            , (ClasificacionRiesgo)r.GetType().GetProperty("Clasificacion").GetValue(r)
                                            , (string)r.GetType().GetProperty("Observacion").GetValue(r)
                                            , (string)r.GetType().GetProperty("Comentario").GetValue(r));
                riesgos.Add(riesgo);
            }
           
            return riesgos;
        }

        public override IList<Riesgo> GetRiesgosAreaNegocio(MatrizControl matrizControl, AreaNegocio areaNegocio)
        {

            return GetRiesgos(matrizControl).Where(x => x.AreaNegocio.Id == areaNegocio.Id).ToList<Riesgo>();
        }

        //public IList<ControlInterno> GetControlesInternos(Riesgo riesgo)
        //{
            
        //    List<ControlInterno> controles = (new NControlInternoPropuesto()).GetControlesInternos(riesgo).ToList<ControlInterno>();
           
        //    controles.AddRange((new NControlInternoObservado()).GetControlesInternos(riesgo));


        //    return controles;

        //}
    }
}
