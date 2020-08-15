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
    public abstract class NControlInterno
    {
        //public void AgregarControlInterno(ControlInterno obj)
        //{
        //    (new MControlInterno()).Operacion(obj, 0);
        //}

        //public void ModificarControlInterno(ControlInterno obj)
        //{
        //    (new MControlInterno()).Operacion(obj, 1);
        //}

        //public void BorrarControlInterno(ControlInterno obj)
        //{
        //    (new MControlInterno()).Operacion(obj, 2);
        //}

        //public abstract IList<ControlInterno> GetControlesInternos();

        public abstract IList<ControlInterno> GetControlesInternos(Riesgo riesgo);


        //public IList<ControlInterno> GetObservaciones(MatrizControl matrizControl, AreaNegocio areaNegocio)
        //{
        //    List<ControlInterno> lControlInterno = new List<ControlInterno>();

        //    //foreach (var r in (new NRiesgo()).GetRiesgosAreaNegocio(matrizControl,areaNegocio))
        //    //{
        //    //    lControlInterno.AddRange(GetControlesInternos(r).Where(x => x.Estado == EstadoControlInterno.Observado));

        //    //}
        //    return lControlInterno;
        //}

        //public bool ControlesNoAceptados()
        //{
        //    bool res = false;

        //    if (GetControlesInternos().Where(x => x.Estado != EstadoControlInterno.Aceptado && x.Estado != EstadoControlInterno.Cancelado).Count() > 0)
        //    {
        //        res = true;
        //    }
        //    return res;
        //}
    }
}
