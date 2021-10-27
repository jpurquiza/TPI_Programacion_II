using Banco.DataAccess;
using Banco.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Servicios
{
    class GestorClientes
    {
        private IClienteDao _clienteDao;
        public GestorClientes(AbstractFactoryDao factory)
        {
            _clienteDao = factory.CargarDatosCliente();
        }
        public List<Cuenta> GetCuentas()
        {
            return _clienteDao.GetCuentas();
        }
    }
}
