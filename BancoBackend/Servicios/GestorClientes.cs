using BancoBackend.DataAccess;
using BancoBackend.Entities;
using BancoBackend.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Servicios
{
    public class GestorClientes : IGestorClientes
    {
        private IClienteDao _clienteDao;

        public GestorClientes()
        {
            _clienteDao = new ClienteDao();
        }

        public bool AltaCliente(Cliente oCliente)
        {
            return _clienteDao.AltaCliente(oCliente);
        }

        public List<Cuenta> GetCuentas()
        {
            return _clienteDao.GetCuentas();
        }

        public List<Destinatarios> GetDestinatarios()
        {
            return _clienteDao.GetDestinatarios();
        }


        public bool Login(int DNI, string Pass)
        {
            return _clienteDao.Login(DNI, Pass);
        }


        public bool EditarDestinatario(Destinatarios oDestinatario)
        {
            return _clienteDao.UpdateDestinatario(oDestinatario);
        }

        public bool GrabarDestinatario(Destinatarios oDestinatario)
        {
            return _clienteDao.InsertDestinatario(oDestinatario);
        }

        public bool GrabarTransferencia(Transferencia oTransferencia)
        {
            return _clienteDao.GrabarTransferencia(oTransferencia);
        }

        public int GetProximoID()
        {
            return _clienteDao.ProximoNro();
        }
    }
}
