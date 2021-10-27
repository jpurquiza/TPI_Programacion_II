using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.DataAccess
{
    class ClienteDaoFactory : AbstractFactoryDao
    {
        public override IClienteDao CargarDatosCliente()
        {
           return new ClienteDao();
        }
    }
}
