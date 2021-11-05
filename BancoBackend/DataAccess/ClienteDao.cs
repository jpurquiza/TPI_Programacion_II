using BancoBackend.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoBackend.Cache;

namespace BancoBackend.DataAccess
{
    public class ClienteDao : IClienteDao
    {
        public List<Cuenta> GetCuentas()
        {
            List<Cuenta> lstCuentas = new List<Cuenta>();

            DataTable table = HelperDao.ObtenerInstancia().ConsultaSQL("SP_CONSULTAR_SALDO_TIPO_CUENTA");

            foreach (DataRow row in table.Rows)
            {
                Cuenta oCuenta = new Cuenta();
                oCuenta.IdCuenta = Convert.ToInt32(row[0].ToString());
                oCuenta.TipoCuenta = row[1].ToString();

                lstCuentas.Add(oCuenta);
            }

            return lstCuentas;
        }

        public List<Destinatarios> GetDestinatarios()
        {
            List<Destinatarios> lstDestinatarios = new List<Destinatarios>();
            DataTable table = HelperDao.ObtenerInstancia().ConsultaSQL("SP_CONSULTAR_DESTINATARIOS");

            foreach (DataRow row in table.Rows)
            {
                Destinatarios oDestinatarios = new Destinatarios();
                oDestinatarios.IdDestinatario = Convert.ToInt32(row[0].ToString());
                oDestinatarios.NroCbu = Convert.ToInt32(row[1].ToString());
                oDestinatarios.Nombre = row[2].ToString();
                oDestinatarios.Apellido = row[3].ToString();
                oDestinatarios.CboAux = row[4].ToString();
                oDestinatarios.Dni = Convert.ToInt32(row[5].ToString());
                oDestinatarios.Email = row[6].ToString();

                lstDestinatarios.Add(oDestinatarios);
            }
            return lstDestinatarios;
        } 

        public bool Login(int DNI, string Pass)
        {
            return HelperDao.ObtenerInstancia().ValidacionLogin("SP_LOGIN", DNI, Pass);
        }

        public bool InsertDestinatario(Destinatarios oDestinatario)
        {
            bool bandera = true;
            try
            {
                //cambiar el id de cliente por el del cache??
                Dictionary<string, object> insert = new Dictionary<string, object>();
                insert.Add("@id_cliente", UserCache.IdClienteLogin);
                insert.Add("@nro_cbu", oDestinatario.NroCbu);
                insert.Add("@nro_dni", oDestinatario.Dni);
                insert.Add("@apellido", oDestinatario.Apellido);
                insert.Add("@nombre", oDestinatario.Nombre);
                insert.Add("@email", oDestinatario.Email);

                HelperDao.ObtenerInstancia().EjecutarSQL("SP_INSERTAR_DESTINATARIO", insert);
            }
            catch (Exception)
            {
                bandera = false;
            }

            return bandera;
        }

        public bool UpdateDestinatario(Destinatarios oDestinatario)
        {
            bool bandera = true;
            try
            {
                Dictionary<string, object> update = new Dictionary<string, object>();
                update.Add("@idDestinatario", oDestinatario.IdDestinatario);
                update.Add("@id_cliente", UserCache.IdClienteLogin);
                update.Add("@nro_cbu", oDestinatario.NroCbu);
                update.Add("@nro_dni", oDestinatario.Dni);
                update.Add("@apellido", oDestinatario.Apellido);
                update.Add("@nombre", oDestinatario.Nombre);
                update.Add("@email", oDestinatario.Email);

                HelperDao.ObtenerInstancia().EjecutarSQL("SP_MODIFICAR_DESTINATARIO", update);
            }
            catch (Exception)
            {
                bandera = false;
            }

            return bandera;
        }

        public bool DeleteDestinatario(int idDestinatario)
        {
            bool bandera = true;
            try
            {
                Dictionary<string, object> delete = new Dictionary<string, object>();
                delete.Add("@id_destinatario", idDestinatario);

                HelperDao.ObtenerInstancia().EjecutarSQL("SP_ELIMINAR_DESTINATARIO", delete);
            }
            catch (Exception)
            {

                bandera = false;
            }

            return bandera;

        }

        public bool AltaCliente(Cliente oCliente)
        {
            return HelperDao.ObtenerInstancia().AltaCliente("SP_ALTA_CLIENTE", oCliente);
        }

        public bool GrabarTransferencia(Transferencia oTransferencia)
        {
            return HelperDao.ObtenerInstancia().AltaTransferencia("SP_INSERTAR_TRANSACCION", oTransferencia);

            //bool bandera = true;
            //try
            //{
            //    //cambiar el id de cliente por el del cache??
            //    Dictionary<string, object> insert = new Dictionary<string, object>();
            //    insert.Add("@id_cuenta", oTransferencia.IdCuenta);
            //    insert.Add("@id_destinatario", oTransferencia.IdDestinatario);
            //    insert.Add("@fecha", oTransferencia.Fecha);
            //    insert.Add("@monto", oTransferencia.Importe);
            //    insert.Add("@concepto", oTransferencia.Concepto);


            //    HelperDao.ObtenerInstancia().EjecutarSQL("SP_INSERTAR_TRANSACCION", insert);
            //}
            //catch (Exception)
            //{
            //    bandera = false;
            //}

            //return bandera;
        }

        public int ProximoNro()
        {
            try
            {

                return HelperDao.ObtenerInstancia().ProximoID("SP_PROXIMO_ID", "@next");

            }
            catch (Exception)
            {
                return 1;
                throw;
            }
        }
    }
}
