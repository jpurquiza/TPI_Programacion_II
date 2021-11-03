using System;
using BancoBackend.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.DataAccess
{
    public interface IClienteDao
    {
        List<Cuenta> GetCuentas();
        List<Destinatarios> GetDestinatarios();
        bool Login(int DniLogin, string ClaveLogin);

    }
}
