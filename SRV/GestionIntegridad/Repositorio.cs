using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using System.Configuration;

namespace Servicios.GestionIntegridad
{
    public class Repositorio
    {
        private SqlConnection Conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SCIDBConnectionString"].ConnectionString);

        private SqlCommand Cmd;
        private SqlTransaction Trx;

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
