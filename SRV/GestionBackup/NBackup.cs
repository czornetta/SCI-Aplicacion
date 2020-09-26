using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.GestionBackup
{
    public class NBackup
    {
        public void CopiarBD()
        {
            (new Repositorio()).CopiarBD();
        }

        public void RestaurarBD(Backup bkp)
        {
            (new Repositorio()).RestaurarBD(bkp);
        }

        public IList<Backup> LeerBackups(Backup bkp)
        {
            return (new Repositorio()).LeerBackups();
        }
    }
}
