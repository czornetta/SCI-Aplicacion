using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Entidades.GestionIntegridad;
using Servicios.Seguridad;

namespace Servicios.GestionIntegridad
{
    public class ControlIntegridad
    {
        
        public bool VerificarRegistro(List<Integridad> lObj)
        {
            bool res = true;

            foreach (var obj in lObj)
            {
                if (!(obj.DigitoVerificador == Cifrado.Cifrar(obj.Registro)))
                {
                    res = false;
                }

            }
                
            return res;
        }

        public bool VerificarEntidad(string entidad, List<Integridad> lObj)
        {
            bool res = true;

            DVEntidad dvv = GetEntidades().Where(x => x.Entidad == entidad).FirstOrDefault();
            DVEntidad dvvC = GetDVV(entidad, lObj);

            if (dvv!=null)
            {
                if (dvv.DigitoVerificador != dvvC.DigitoVerificador)
                {
                    res = false;
                }
                
            }
            else
            {
                res = false;
            }

            return res;
        }

        public string GetDVH(string registro)
        {
            return Cifrado.Cifrar(registro);
        }

        public DVEntidad GetDVV(string entidad, List<Integridad> lObj)
        {
            
            DVEntidad dvv = new DVEntidad();
            dvv.Entidad = entidad;
            int n = 0;

            foreach (var obj in lObj)
            {
                n += obj.Registro.Length * Cifrado.Cifrar(obj.Registro).Length;    
            }
            dvv.DigitoVerificador = Cifrado.Cifrar(string.Concat(n.ToString(), lObj.Count()));

            return dvv;
        }

        public bool VerificarConfiguracion(string entidad)
        {
            bool res = true;

            DVEntidad dvv = (new MControlIntegridad()).GetEntidades().Where(x => x.Entidad == entidad).FirstOrDefault();
            

            if (dvv == null)
            {
                res = false;
            }

            return res;
        }

        public IList<DVEntidad> GetEntidades()
        {
            return (new MControlIntegridad()).GetEntidades();
            
        }
    }
}
