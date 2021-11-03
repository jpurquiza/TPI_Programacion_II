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

        public bool Login(int DniLogin, string ClaveLogin)
        {
            return _clienteDao.Login(DniLogin, ClaveLogin);
        }
    }
}
