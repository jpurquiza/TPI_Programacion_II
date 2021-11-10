using BancoBackend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Servicios
{
    public interface IGestorClientes
    {
        public List<Cuenta> GetCuentas();
        public List<Cuenta> GetTipoCuentas();
        public List<Destinatarios> GetDestinatarios();
        public bool Login(int DNI, string Pass);
        public bool AltaCliente(Cliente oCliente);

        /*bool ValidarModificarDestinatario(int CBU, int DNI,int idDestinatario);*/
        bool ValidarDestinatario(int idCliente, int CBU, int DNI);
        bool EditarDestinatario(Destinatarios oDestinatario);
        bool GrabarDestinatario(Destinatarios oDestinatario);
        bool EliminarDestinatario(int idDestinatario);
        bool GrabarTransferencia(Transferencia oTransferencia);
        bool GrabarCuenta(Cuenta oCuenta);
    }
}
