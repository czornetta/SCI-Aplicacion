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
        
        public bool verificarRegistro(Integridad obj)
        {
            bool res = false;
            if (obj.DigitoVerificador == Cifrado.Cifrar(obj.Registro))
            {
                res = true;
            }
                
            return res;
        }
    }
}
