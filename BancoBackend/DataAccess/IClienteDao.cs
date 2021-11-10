using System;
using BancoBackend.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.DataAccess
{
    public interface IClienteDao
    {
        List<Cuenta> GetCuentas();
        List<Cuenta> GetTipoCuentas();
        List<Destinatarios> GetDestinatarios();
        bool Login(int DNI, string Pass);
        bool AltaCliente(Cliente oCliente);
        /*bool ValidateModifyDestinatario(int CBU, int DNI,int idDestinatario);*/
        bool ValidateDestinatario(int idCliente, int CBU, int DNI);
        bool InsertDestinatario(Destinatarios oDestinatario);
        bool UpdateDestinatario(Destinatarios oDestinatario);
        bool DeleteDestinatario(int idDestinatario);
        bool InsertTransferencia(Transferencia oTransferencia);
        bool InsertCuenta(Cuenta oCuenta);
    }
}
