using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.DataAccess
{
    abstract class AbstractFactoryDao
    {
        public abstract IClienteDao CargarDatosCliente();
    }
}
