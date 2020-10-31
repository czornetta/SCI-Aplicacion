using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using Entidades.GestionIntegridad;
using System.Configuration;

namespace AccesoDatos
{
    public class Acceso
    {
        private string StringConn = ConfigurationManager.ConnectionStrings["SCIDBConnectionString"].ConnectionString;
        private SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SCIDBConnectionString"].ConnectionString);

        private SqlCommand Cmd;
        private SqlTransaction Trx;

        public void Escribir(string sql, Hashtable param, DVEntidad dvv=null)
        {
            
            try
            {
                if (Conn.State == ConnectionState.Closed)
                {
                    Conn.ConnectionString = StringConn;
                    Conn.Open();
                }

                Trx = Conn.BeginTransaction();
                Cmd = new SqlCommand(sql,Conn,Trx);
                Cmd.CommandType = CommandType.StoredProcedure;

                if (param.Count >0)
                {
                    foreach (string p in param.Keys)
                    {
                        Cmd.Parameters.AddWithValue(p,param[p]);
                    }
                }

                Cmd.ExecuteNonQuery();

                // Digito verificador vertical
                if (dvv != null)
                {
                    Cmd = new SqlCommand("updDVEntidad", Conn, Trx);
                    Cmd.CommandType = CommandType.StoredProcedure;
                    
                    Cmd.Parameters.AddWithValue("@entidad", dvv.Entidad);
                    Cmd.Parameters.AddWithValue("@dventidad", dvv.DigitoVerificador);
                    Cmd.ExecuteNonQuery();
                }

                Trx.Commit();
               
            }
            catch (SqlException ex)
            {
                Trx.Rollback();
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                Trx.Rollback();
                throw new Exception(ex.Message);
            }
            
        }

        //public int Escribir(string sql, Hashtable param)
        //{

        //    try
        //    {
        //        if (Conn.State == ConnectionState.Closed)
        //        {
        //            Conn.ConnectionString = StringConn;
        //            Conn.Open();
        //        }

        //        Trx = Conn.BeginTransaction();
        //        Cmd = new SqlCommand(sql, Conn, Trx);
        //        Cmd.CommandType = CommandType.StoredProcedure;

        //        if (param.Count > 0)
        //        {
        //            foreach (string p in param.Keys)
        //            {
        //                Cmd.Parameters.AddWithValue(p, param[p]);
        //            }
        //        }

        //        int id = Cmd.ExecuteNonQuery();
                                

        //        Trx.Commit();

        //        return id;
        //    }
        //    catch (SqlException ex)
        //    {
        //        Trx.Rollback();
        //        throw new Exception(ex.Message);
        //    }
        //    catch (Exception ex)
        //    {
        //        Trx.Rollback();
        //        throw new Exception(ex.Message);
        //    }

        //}

        public DataSet Leer(string sql, Hashtable param)
        {
            DataSet res = new DataSet();
            try
            {
                Cmd = new SqlCommand(sql, Conn);
                Cmd.CommandType = CommandType.StoredProcedure;

                if (param.Count > 0)
                {
                    foreach (string p in param.Keys)
                    {
                        Cmd.Parameters.AddWithValue(p, param[p]);
                    }
                }
                SqlDataAdapter Sda = new SqlDataAdapter(Cmd);

                Sda.Fill(res);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return res;

        }
    }
}
