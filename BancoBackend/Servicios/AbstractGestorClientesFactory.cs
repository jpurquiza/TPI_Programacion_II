using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Servicios
{
    abstract class AbstractGestorClientesFactory
    {
        public abstract IGestorClientes CrearService();
    }
}
