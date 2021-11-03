using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.DataAccess
{
    public abstract class AbstractFactoryDao
    {
        public abstract IClienteDao CargarDatosCliente();
    }
}
