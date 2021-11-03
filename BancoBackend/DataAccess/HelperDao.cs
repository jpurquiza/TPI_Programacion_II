using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BancoBackend.Cache;

namespace BancoBackend.DataAccess
{
    public class HelperDao
    {
        private static HelperDao instancia;
        private string connectionString;
        private HelperDao()
        {
            connectionString = @"Data Source=DRAGONSTONE\SQLEXPRESS;Initial Catalog=banco;Integrated Security=True";
        }
        public static HelperDao ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new HelperDao();
            }
            return instancia;
        }
        public DataTable ConsultaSQL(string SPName)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();
            try
            {
                cnn.ConnectionString = connectionString;
                cnn.Open();

                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = SPName;
                cmd.Parameters.AddWithValue("@id_cliente", 3);
                //UserCache.IdClienteLogin
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { this.CloseConnection(cnn); }
        }

        public bool ValidacionLogin(string SPName, int DniLogin, string ClaveLogin)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cnn.ConnectionString = connectionString;
                cnn.Open();

                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = SPName;
                cmd.Parameters.AddWithValue("@DniLogin", DniLogin);
                cmd.Parameters.AddWithValue("@ClaveLogin", ClaveLogin);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UserCache.IdClienteLogin = reader.GetInt32(0);
                        UserCache.DniLogin = reader.GetInt32(1);
                        UserCache.ClaveLogin = reader.GetString(2);
                        UserCache.ApellidoLogin = reader.GetString(3);
                        UserCache.NombreLogin = reader.GetString(4);
                        UserCache.EmailLogin = reader.GetString(5);
                    }
                     
                    return true;

                }

                else return false;
               
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally { this.CloseConnection(cnn); }
        }


        public int EjecutarSQLConValorOUT(string nombreSP, string nombreParametro)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlParameter param = new SqlParameter();
            int val;
            try
            {
                cnn.Open();
                // Command Type para el Tipo de COmando que quiero ejecutar
                // cmd.CommandText = CommandType.Text;  ejecutamos sql como texto plano
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombreSP;
                param.ParameterName = nombreParametro;
                param.SqlDbType = SqlDbType.Int;
                param.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(param);
                cmd.ExecuteScalar();
                val = (int)param.Value;

            }
            catch (SqlException)
            {
                val = 0;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }

            return val;
        }



        private void CloseConnection(SqlConnection cnn)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
    }
}
