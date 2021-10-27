using System;
using Banco.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.DataAccess
{
    interface IClienteDao
    {
        List<Cuenta> GetCuentas();
        List<Destinatarios> GetDestinatarios();

    }
}
