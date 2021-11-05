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
        List<Destinatarios> GetDestinatarios();
        bool Login(int DNI, string Pass);
        bool AltaCliente(Cliente oCliente);
        bool InsertDestinatario(Destinatarios oDestinatario);
        bool UpdateDestinatario(Destinatarios oDestinatario);
        bool DeleteDestinatario(int idDestinatario);
        bool GrabarTransferencia(Transferencia oTransferencia);
        int ProximoNro();
    }
}
