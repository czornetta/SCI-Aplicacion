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
    public class NMatrizControl
    {
        public void AgregarMatrizControl(MatrizControl obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("MatrizControl");

                if (!(obj.Periodo > 0))
                    throw new AtributoNotNullException("Periodo");

                if (obj.Estado == null)
                    obj.Estado = new EstadoMatrizControl {Id=1};

                (new MMatrizControl()).Operacion(obj, 0);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void ModificarMatrizControl(MatrizControl obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("MatrizControl");

                if (!(obj.Id > 0))
                    throw new AtributoNotNullException("Id");

                if (!(obj.Periodo >0))
                    throw new AtributoNotNullException("Periodo");

                if (obj.Estado == null)
                    throw new AtributoNotNullException("Estado");

                (new MMatrizControl()).Operacion(obj, 1);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public void BorrarMatrizControl(MatrizControl obj)
        {
            try
            {
                if (obj == null)
                    throw new AtributoNotNullException("MatrizControl");

                if (!(obj.Id > 0))
                    throw new AtributoNotNullException("Id");

                
                (new MMatrizControl()).Operacion(obj, 2);
            }
            catch (Exception ex) when (ex.GetType() != typeof(AtributoNotNullException))
            {
                throw new Exception(ex.Message);
            }
            
        }

        public IList<MatrizControl> GetMatricesControl()
        {
            return (new MMatrizControl()).Leer();
        }

        public MatrizControl GetMatrizControlRelevamiento()
        {
            return GetMatricesControl().FirstOrDefault(x => x.Estado.Id == 1);
        }

        public MatrizControl GetMatrizControlDefinicion()
        {
            return GetMatricesControl().FirstOrDefault(x => x.Estado.Id == 2);
        }

        public MatrizControl GetMatrizControlActiva()
        {
            return GetMatricesControl().FirstOrDefault(x => x.Estado.Id == 3);
        }

        public IEnumerable GetRiesgosResumenAreaNegocio(MatrizControl matrizControl)
        {
            
            var lestadoRiesgo = (new NEstadoRiesgo()).GetEstadosRiesgo();

            List<Riesgo> riesgos = (new NRiesgoPropuesto()).GetRiesgos(matrizControl).ToList<Riesgo>();
            var resumen = (from p in riesgos
                           group p by p.AreaNegocio into grupo
                           select new
                           {
                               AreaNeocio = grupo.Key,
                               Estado = lestadoRiesgo.FirstOrDefault(x => x.Clase == typeof(RiesgoPropuesto).ToString()),
                               CantidadRiesgos = grupo.Count()
                           }).ToList();

            riesgos = (new NRiesgoObservado()).GetRiesgos(matrizControl).ToList<Riesgo>();
            resumen.AddRange((from p in riesgos
                              group p by p.AreaNegocio into grupo
                              select new
                              {
                                  AreaNeocio = grupo.Key,
                                  Estado = lestadoRiesgo.FirstOrDefault(x => x.Clase == typeof(RiesgoObservado).ToString()),
                                  CantidadRiesgos = grupo.Count()
                              }).ToList());

            riesgos = (new NRiesgoAceptado()).GetRiesgos(matrizControl).ToList<Riesgo>();
            resumen.AddRange((from p in riesgos
                              group p by p.AreaNegocio into grupo
                              select new
                              {
                                  AreaNeocio = grupo.Key,
                                  Estado = lestadoRiesgo.FirstOrDefault(x => x.Clase == typeof(RiesgoAceptado).ToString()),
                                  CantidadRiesgos = grupo.Count()
                              }).ToList());
           
            return resumen;
        }

        public IList<Riesgo> GetRiesgosAreaNegocio(MatrizControl matrizControl, AreaNegocio areaNegocio, EstadoRiesgo estado)
        {
            List<Riesgo> riesgos = new List<Riesgo>();    

            if (estado.Clase.Equals(typeof(RiesgoPropuesto).ToString()))
            {
                riesgos = (new NRiesgoPropuesto()).GetRiesgosAreaNegocio(matrizControl, areaNegocio).ToList<Riesgo>();
            }
            else if (estado.Clase.Equals(typeof(RiesgoObservado).ToString()))
            {
                riesgos = (new NRiesgoObservado()).GetRiesgosAreaNegocio(matrizControl, areaNegocio).ToList<Riesgo>();
            }
            else if (estado.Clase.Equals(typeof(RiesgoAceptado).ToString()))
            {
                riesgos = (new NRiesgoAceptado()).GetRiesgosAreaNegocio(matrizControl, areaNegocio).ToList<Riesgo>();
            }

            return riesgos;
        }

        public IList<ControlInterno> GetControlesInternosObs(MatrizControl matrizControl, AreaNegocio areaNegocio)
        {
            List<ControlInterno> controles = new List<ControlInterno>();


            foreach (var item in (new NRiesgoAceptado()).GetRiesgosAreaNegocio(matrizControl, areaNegocio))
            {
                    controles.AddRange((new NControlInternoObservado()).GetControlesInternos(item));
            }

            return controles;
        }

        public IEnumerable GetResumen(MatrizControl matrizControl)
        {
            return (new MMatrizControl()).LeerMatrizControlResumen(matrizControl);
        }

        public bool RiesgosSinControl(MatrizControl matrizControl)
        {
            bool res = false;
            NControlInternoAceptado nControlInternoAceptado = new NControlInternoAceptado();
            

            foreach (var item in (new NRiesgoAceptado()).GetRiesgos(matrizControl))
            {
                if (nControlInternoAceptado.GetControlesInternos(item).Count()==0)
                {
                    res = true;
                    break;
                }

            }

            return res;
        }

        public bool ControlNoAceptado(MatrizControl matrizControl)
        {
            bool res = false;
            NControlInternoPropuesto nControlInternoPrupuesto = new NControlInternoPropuesto();
            NControlInternoObservado nControlInternoObservado = new NControlInternoObservado();

            foreach (var item in (new NRiesgoAceptado()).GetRiesgos(matrizControl))
            {
                if (nControlInternoPrupuesto.GetControlesInternos(item).Count() > 0)
                {
                    res = true;
                    break;
                }

                if (nControlInternoObservado.GetControlesInternos(item).Count() > 0)
                {
                    res = true;
                    break;
                }
            }

            return res;
        }

        public IList<ControlInterno> GetControlesInternos(MatrizControl matrizControl, AreaNegocio areaNegocio)
        {
            List<ControlInterno> controles = new List<ControlInterno>();


            foreach (var item in (new NRiesgoAceptado()).GetRiesgosAreaNegocio(matrizControl, areaNegocio))
            {
                controles.AddRange((new NControlInternoAceptado()).GetControlesInternos(item));
            }

            return controles;
        }

        public IList<ControlInterno> GetControlesInternos(MatrizControl matrizControl)
        {
            List<ControlInterno> controles = new List<ControlInterno>();


            foreach (var item in (new NRiesgoAceptado()).GetRiesgos(matrizControl))
            {
                controles.AddRange((new NControlInternoAceptado()).GetControlesInternos(item));
            }

            return controles;
        }
    }
}
