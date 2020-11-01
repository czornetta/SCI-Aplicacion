using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Servicios.GestionBackup
{
    public class NInstanciaBD
    {
        public List<string> GetInstancias()
        {
            return (new Repositorio()).GetInstancias();
        }

        public void CrearBD()
        {
            Repositorio repo = new Repositorio();

            TextReader sqlFile = new StreamReader("ScriptSCIDB.sql");
            string sql = sqlFile.ReadToEnd();

            repo.CrearBD(sql);

            sqlFile = new StreamReader("ScriptSCITP.sql");
            sql = sqlFile.ReadToEnd();

            repo.CrearBD(sql);
            
        }
    }
}
