using Banco.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.DataAccess
{
    class ClienteDao : IClienteDao
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
                oCuenta.Saldo = Convert.ToInt32(row[2].ToString());

                lstCuentas.Add(oCuenta);
            }

            return lstCuentas;
        }

        public List<Destinatarios> GetDestinatarios()
        {
            throw new NotImplementedException();
        }
    }
}
