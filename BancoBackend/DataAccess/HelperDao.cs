using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BancoBackend.Cache;
using BancoBackend.Entities;

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
                //TODO:a veces el idClienteLogin es 0,revisar kpos
                cmd.Parameters.AddWithValue("@id_cliente", UserCache.IdClienteLogin);
                tabla.Load(cmd.ExecuteReader());
                return tabla;
            }
            catch (SqlException)
            {
                throw;
            }
            finally { this.CloseConnection(cnn); }
        }

        public bool ValidacionLogin(string SPName, int DNI, string Pass)
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
                cmd.Parameters.AddWithValue("@DniLogin", DNI);
                cmd.Parameters.AddWithValue("@ClaveLogin", Pass);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UserCache.IdClienteLogin = reader.GetInt32(0);
                        UserCache.ApellidoLogin = reader.GetString(3);
                        UserCache.NombreLogin = reader.GetString(4);
                        UserCache.EmailLogin = reader.GetString(5);
                    }
                     
                    return true;

                }

                else return false;
               
            }
            catch (SqlException e)
            {
                var a = e;
                throw;

            }
            finally { this.CloseConnection(cnn); }
        }

        public bool AltaCliente(string SPName, Cliente oCliente)

        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction transaccion = null;
            bool flag = true;

            try
            {
                cnn.ConnectionString = connectionString;
                cnn.Open();
                transaccion = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = SPName;
                cmd.Transaction = transaccion;
                cmd.Parameters.AddWithValue("@nro_dni", oCliente.Dni);
                cmd.Parameters.AddWithValue("@apellido", oCliente.Apellido);
                cmd.Parameters.AddWithValue("@nombre", oCliente.Nombre);
                cmd.Parameters.AddWithValue("@email", oCliente.Email);

                cmd.ExecuteNonQuery();

                transaccion.Commit();

            }
            catch
            {
                transaccion.Rollback();
                flag = false;
            }
            finally { this.CloseConnection(cnn); }

            return flag;
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


        //PROBAR
        public int EjecutarSQL(string nombreSP, Dictionary<string, object> parametros)
        {
            SqlConnection cnn = new SqlConnection();

            SqlCommand cmd = new SqlCommand();
            int filasAfectadas = 0;

            try
            {
                cnn.ConnectionString = connectionString;
                cnn.Open();

                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombreSP;

                foreach (var item in parametros)
                {
                    //item.Key devuelve el string del nombre del parametro
                    //item.Value ingresa el valor al parametro
                    //CLAVE - VALOR
                    cmd.Parameters.AddWithValue(item.Key, item.Value);
                }

                filasAfectadas = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally { this.CloseConnection(cnn); }

            return filasAfectadas;
        }
        //




        //ver estoooooooooooooooooo
        public bool ValidacionInsertDestinatario(int idCliente, int CBU,int DNI)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cnn.ConnectionString = connectionString;
                cnn.Open();

                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_VALIDAR_INSERT_DESTINATARIO";
                cmd.Parameters.AddWithValue("@idCliente", UserCache.IdClienteLogin);
                cmd.Parameters.AddWithValue("@nro_cbu", CBU);
                cmd.Parameters.AddWithValue("@nro_dni", DNI);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                   
                    return false;
                }
                else return true;
            }
            catch (SqlException e)
            {
                var a = e;
                throw;
            }
            finally { this.CloseConnection(cnn); }
        }



        /*public bool ValidacionModifyDestinatario( int CBU, int DNI, int idDestinatario)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();

            try
            {
                cnn.ConnectionString = connectionString;
                cnn.Open();

                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_VALIDAR_IMODIFY_DESTINATARIO";
                //cmd.Parameters.AddWithValue("@idCliente", UserCache.IdClienteLogin);
                cmd.Parameters.AddWithValue("@nro_cbu", CBU);
                cmd.Parameters.AddWithValue("@nro_dni", DNI);
                cmd.Parameters.AddWithValue("@id_destinatario", idDestinatario);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {

                    return false;
                }
                else return true;
            }
            catch (SqlException e)
            {
                var a = e;
                throw;
            }
            finally { this.CloseConnection(cnn); }
        }*/



        private void CloseConnection(SqlConnection cnn)
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
    }
}
