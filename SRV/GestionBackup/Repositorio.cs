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

                Conn.ConnectionString = @"Data Source=.\SQLEXPRESS;Database=master;Integrated Security=True";

                Conn.Open();
                string sqlrestore = @"ALTER DATABASE SCIDB
                                        SET SINGLE_USER
                                        WITH ROLLBACK IMMEDIATE
                                        RESTORE DATABASE SCIDB FROM DISK = '";

                sqlrestore = string.Concat(sqlrestore,bkp.Archivo,"';");
                
                //throw new Exception(sqlrestore);
                
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

                Conn.ConnectionString = @"Data Source=.\SQLEXPRESS;Database=master;Integrated Security=True";
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

                } 

                if (Conn.State == ConnectionState.Open)
                {
                    test = true;
                }
                Conn.Close();
            }
            catch (SqlException)
            {
                test = false;
            }
            catch (Exception)
            {
                test = false;
            }

            return test;
        }
    }
}
