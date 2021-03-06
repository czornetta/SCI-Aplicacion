﻿using System;
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
    public class NRiesgoPropuesto: NRiesgo
    {
        public void AgregarRiesgo(RiesgoPropuesto obj)
        {
            (new MRiesgo()).Operacion(obj, 0);
        }

        public void ModificarRiesgo(RiesgoPropuesto obj)
        {
            (new MRiesgo()).Operacion(obj, 1);
        }

        public void BorrarRiesgo(RiesgoPropuesto obj)
        {
            (new MRiesgo()).Operacion(obj, 2);
        }

        public override IList<Riesgo> GetRiesgos(MatrizControl matrizControl)
        {
            List<Riesgo> riesgos = new List<Riesgo>();
            RiesgoPropuesto riesgo;
            var estadoRiesgo = (new NEstadoRiesgo()).GetEstadosRiesgo().FirstOrDefault(x => x.Clase == typeof(RiesgoPropuesto).ToString());
           

            foreach (var r in (new MRiesgo()).Leer(matrizControl, estadoRiesgo))
            {
            
                riesgo = new RiesgoPropuesto((int)r.GetType().GetProperty("Id").GetValue(r)
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

        public void AceptarRiesgo(RiesgoPropuesto obj)
        {
            var estadoRiesgo = (new NEstadoRiesgo()).GetEstadosRiesgo().FirstOrDefault(x => x.Clase == typeof(RiesgoAceptado).ToString());
            (new MRiesgo()).SetEstadoRiesgo(obj, estadoRiesgo);
        }

        public void ObservarRiesgo(RiesgoPropuesto obj)
        {
            var estadoRiesgo = (new NEstadoRiesgo()).GetEstadosRiesgo().FirstOrDefault(x => x.Clase == typeof(RiesgoObservado).ToString());
            (new MRiesgo()).SetEstadoRiesgo(obj, estadoRiesgo);
        }
    }
}
