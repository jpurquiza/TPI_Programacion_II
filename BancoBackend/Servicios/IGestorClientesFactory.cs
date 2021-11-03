using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Servicios
{
    class IGestorClientesFactory : AbstractGestorClientesFactory
    {
        public override IGestorClientes CrearService()
        {
            return new GestorClientes();
        }
    }
}
