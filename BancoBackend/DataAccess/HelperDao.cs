using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BancoBackend.Cache;
using BancoBackend.Entities;
using System.IO;

namespace BancoBackend.DataAccess
{
    enum Errors { };

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
            catch (SqlException)
            {
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
        public bool AltaTransferencia(string SPName, Transferencia oTransferencia)

        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction transaccion = null;
            bool flag = true;
            int filasAfectadas;

            try
            {
                cnn.ConnectionString = connectionString;
                cnn.Open();
                transaccion = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = SPName;
                cmd.Transaction = transaccion;
                //cmd.Parameters.AddWithValue("@id_transaccion", oTransferencia.IdTransferencia);
                cmd.Parameters.AddWithValue("@id_cuenta", oTransferencia.IdCuenta);
                cmd.Parameters.AddWithValue("@id_destinatario", oTransferencia.IdDestinatario);
                cmd.Parameters.AddWithValue("@fecha", oTransferencia.Fecha);
                cmd.Parameters.AddWithValue("@concepto", oTransferencia.Concepto);
                cmd.Parameters.AddWithValue("@monto", oTransferencia.Importe);

                filasAfectadas = cmd.ExecuteNonQuery();
                if (filasAfectadas != -1)
                {
                    transaccion.Commit();
                    return flag = true;
                }
                else { return flag = false; }

            }
            catch (SqlException e)
            {
                var message = string.Empty;

                foreach (SqlError sqlError in e.Errors)
                {
                    switch (sqlError.Number)
                    {
                        case 35888:
                            message = "Índice inválido.";
                            break;
                        case 6540456:
                            message = "Periodo inválido.";
                            break;
                    }
                    try
                    {
                        transaccion.Rollback();
                        throw new ArgumentException(message);
                    }
                    catch (Exception Exe)
                    {
                        throw new InvalidOperationException("Error en el rollback", Exe);
                    }
                }
                throw new DataException("Problemas de conexión con la base de datos.", e);
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
                this.CloseConnection(cnn);
            }

            return val;
        }

        //PROBAR
        public int EjecutarSQL(string nombreSP, Dictionary<string, object> parametros)
        {
            SqlConnection cnn = new SqlConnection(connectionString);

            SqlCommand cmd = new SqlCommand();
            int filasAfectadas = 0;

            try
            {
                cnn.Open();
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
                string filePath = @"C:\Users\Error.txt";

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine("-----------------------------------------------------------------------------");
                    writer.WriteLine("Date : " + DateTime.Now.ToString());
                    writer.WriteLine();

                    while (ex != null)
                    {
                        writer.WriteLine(ex.GetType().FullName);
                        writer.WriteLine("Message : " + ex.Message);
                        writer.WriteLine("StackTrace : " + ex.StackTrace);

                        ex = ex.InnerException;
                    }
                }
            }
            finally
            {
                this.CloseConnection(cnn);
            }

            return filasAfectadas;
        }
        //
        public int ProximoID(string nombreSP, string paramSP)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlParameter param = new SqlParameter(paramSP, SqlDbType.Int);

            try
            {
                cnn.ConnectionString = connectionString;
                cnn.Open();

                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nombreSP;

                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();

                return Convert.ToInt32(param.Value);
            }

            catch (SqlException ex)
            {
                throw (ex);
            }
            finally { this.CloseConnection(cnn); }
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
