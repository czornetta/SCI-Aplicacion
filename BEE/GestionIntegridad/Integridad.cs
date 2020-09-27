using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.GestionIntegridad
{
    public abstract class Integridad
    {
        public abstract string Registro { get; }
        public string DigitoVerificador { get; set; }

    }
}
