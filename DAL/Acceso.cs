﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace AccesoDatos
{
    public class Acceso
    {
        private string StringConn = @"Data Source=.\SQLEXPRESS;Initial Catalog=SCIDB;Integrated Security=True";
        private SqlConnection Conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SCIDB;Integrated Security=True");
        private SqlCommand Cmd;
        private SqlTransaction Trx;

        public void Escribir(string sql, Hashtable param)
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
