using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Servicios.GestionBackup
{
    public class InstanciaBD
    {
        public string Nombre
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["SCIDBConnectionString"].ConnectionString;
            }
            set
            {
                string dataSource = ConfigurationManager.AppSettings["dataSource"].ToString();
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                config.ConnectionStrings.ConnectionStrings["SCIDBConnectionString"].ConnectionString.Replace(dataSource,value);
                config.ConnectionStrings.ConnectionStrings["MasterConnectionString"].ConnectionString.Replace(dataSource, value);
                ConfigurationManager.AppSettings["dataSource"] = value;

                config.Save(ConfigurationSaveMode.Modified);
            }
        }

        public bool EstadoBD { get 
            {
                return  (new Repositorio()).TestBD();
            } }

    }
}
