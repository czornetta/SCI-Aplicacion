using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using Entidades.Seguridad;
using Servicios.Seguridad;
using System.Configuration;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace Servicios.GestionBackup
{
    public class Repositorio
    {
        private string StringConn = ConfigurationManager.ConnectionStrings["SCIDBConnectionString"].ConnectionString;
        private SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SCIDBConnectionString"].ConnectionString);

        private SqlCommand Cmd;

        public void CopiarBD()
        {
            
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.ConnectionString = StringConn;
                    Conn.Open();
                }

                Cmd = new SqlCommand("doBackup", Conn);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("idusuario", Sesion.Instancia.Usuario.IdUsuario);
                    
                Cmd.ExecuteNonQuery();
               
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RestaurarBD(Backup bkp)
        {

            try
            {
                string baseDatos = ConfigurationManager.AppSettings["dataBase"].ToString();
                Conn.ConnectionString = ConfigurationManager.ConnectionStrings["MasterConnectionString"].ConnectionString;

                Conn.Open();
                string sqlrestore = @"ALTER DATABASE {0}
                                        SET SINGLE_USER
                                        WITH ROLLBACK IMMEDIATE
                                        RESTORE DATABASE {0} FROM DISK = '{1}';";

                //sqlrestore = string.Concat(sqlrestore,bkp.Archivo,"';");
                sqlrestore = string.Format(sqlrestore, baseDatos,bkp.Archivo);

                Cmd = new SqlCommand(sqlrestore, Conn);
                Cmd.CommandType = CommandType.Text;

                Cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public IList<Backup> LeerBackups()
        {
            DataSet res = new DataSet();
            try
            {
                Cmd = new SqlCommand("getBackups", Conn);
                Cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter Sda = new SqlDataAdapter(Cmd);

                Sda.Fill(res);

                var bkps = (from reg in res.Tables[0].AsEnumerable()
                           select new Backup
                           {
                               Fecha = reg.Field<DateTime>("fecha"),
                               Usuario = new Usuario
                               {
                                   IdUsuario = reg.Field<int>("idusuario"),
                                   Nombre = reg.Field<string>("nombre")
                               },
                               Archivo = reg.Field<string>("archivo")
                           }).ToList<Backup>();

                return bkps;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void CrearBD(string sql)
        {

            try
            {
                if (Conn.State == ConnectionState.Open)
                {
                    Conn.Close();    
                }

                Conn.ConnectionString = ConfigurationManager.ConnectionStrings["MasterConnectionString"].ConnectionString;
                
                Conn.Open();

                Cmd = new SqlCommand();
                Cmd.Connection = Conn;
                Cmd.CommandType = CommandType.Text;

                var scripts = Regex.Split(sql, "GO", RegexOptions.Multiline);
                foreach (var splitScript in scripts)
                {
                    Cmd.CommandText = splitScript;
                    Cmd.ExecuteNonQuery();
                }
                Conn.Close();
            }
            catch (SqlException ex)
            {
                Conn.Close();
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool TestBD()
        {
            bool test = false;
            try
            {
                Conn.ConnectionString = StringConn;
                Conn.Open();

                while (Conn.State == ConnectionState.Connecting)
                {
                    test = false;
                } 

                if (Conn.State == ConnectionState.Open)
                {
                    test = true;
                }
                
            }

            catch (SqlException)
            {
                test = false;
            }
            catch (Exception)
            {
                test = false;
            }
            finally
            {
                if (Conn.State != ConnectionState.Closed)
                {
                    Conn.Close();
                }
            }

            return test;
        }

        public List<string> GetInstancias()
        {
            List<string> instancias = new List<string>();

            try
            {
                
                string ServerName = Environment.MachineName;
                RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
                using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
                {
                    RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                    if (instanceKey != null)
                    {
                        foreach (var instanceName in instanceKey.GetValueNames())
                        {
                            instancias.Add(".\\" + instanceName);
                        }
                    }
                }
                
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
            return instancias;
        }
        
    }
}
