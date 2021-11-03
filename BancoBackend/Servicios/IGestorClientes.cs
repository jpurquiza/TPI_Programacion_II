using BancoBackend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Servicios
{
    public interface IGestorClientes
    {
        public List<Cuenta> GetCuentas();
        public List<Destinatarios> GetDestinatarios();
        public bool Login(int DniLogin, string ClaveLogin);
    }
}
