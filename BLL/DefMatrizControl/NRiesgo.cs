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
    public abstract class NRiesgo
    {

        public abstract IList<Riesgo> GetRiesgos(MatrizControl matrizControl);

        public abstract IList<Riesgo> GetRiesgosAreaNegocio(MatrizControl matrizControl, AreaNegocio areaNegocio);

        //public IList<Riesgo> GetRiesgosAreaNegocio(MatrizControl matrizControl,AreaNegocio areaNegocio)
        //{
        //    return (new MRiesgo()).Leer(matrizControl).Where(x => x.AreaNegocio.Id == areaNegocio.Id).ToList<Riesgo>();
        //}

        //public IEnumerable GetRiesgosXAreaNegocio(MatrizControl matrizControl)
        //{
        //    var riesgos = (from p in GetRiesgos(matrizControl)
        //                   group p by p.AreaNegocio into grupo
        //                  select new
        //                  { 
        //                      AreaNeocio = grupo.Key, 
        //                      CantidadRiesgos = grupo.Count()
        //                  }).ToList();

        //    return riesgos;
        //}

        //public bool RiesgosNoAceptados(MatrizControl matrizControl)
        //{
        //    bool res = false;

        //    if ((new MRiesgo()).LeerRiesgosNoAceptados(matrizControl).Count() >0)
        //    {
        //        res = true;
        //    }
        //    return res;
        //}

        //public IList<Riesgo> GetRiesgosObservados(MatrizControl matrizControl)
        //{
        //    return (new MRiesgo()).LeerRiesgosObservados(matrizControl);
        //}

        //public IList<Riesgo> GetRiesgosPropuestos(MatrizControl matrizControl)
        //{
        //    return (new MRiesgo()).LeerRiesgosPropuestos(matrizControl);
        //}

    }
}
