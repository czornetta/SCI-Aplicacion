using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Seguridad;

namespace Servicios.GestionBackup
{
    public class Backup
    {
        public Usuario Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Archivo { get; set; }
        
    }
}
