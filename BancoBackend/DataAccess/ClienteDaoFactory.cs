using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.DataAccess
{
    public class ClienteDaoFactory : AbstractFactoryDao
    {
        public override IClienteDao CargarDatosCliente()
        {
           return new ClienteDao();
        }
    }
}
