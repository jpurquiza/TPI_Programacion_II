using BancoBackend.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.DataAccess
{
    public class ClienteDao : IClienteDao
    {
        public bool AltaCliente(Cliente oCliente)
        {
            return HelperDao.ObtenerInstancia().AltaCliente("SP_ALTA_CLIENTE", oCliente);
        }

        public List<Cuenta> GetCuentas()
        {
            List<Cuenta> lstCuentas = new List<Cuenta>();

            DataTable table = HelperDao.ObtenerInstancia().ConsultaSQL("SP_CONSULTAR_SALDO_TIPO_CUENTA");

            foreach (DataRow row in table.Rows)
            {
                Cuenta oCuenta = new Cuenta();
                oCuenta.IdCuenta = Convert.ToInt32(row[0].ToString());
                oCuenta.TipoCuenta = row[1].ToString();
                oCuenta.Saldo = Convert.ToInt32(row[2].ToString());

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
                oDestinatarios.Dni = Convert.ToInt32(row[4].ToString());
                oDestinatarios.Email = row[5].ToString();

                lstDestinatarios.Add(oDestinatarios);
            }
            return lstDestinatarios;
        } 

        public bool Login(int DniLogin, string ClaveLogin)
        {
            return HelperDao.ObtenerInstancia().ValidacionLogin("SP_LOGIN", DniLogin, ClaveLogin);
        }
    }
}
