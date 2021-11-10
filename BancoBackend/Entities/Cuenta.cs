using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Entities
{
    public class Cuenta
    {
        public int IdCuenta { get; set; }
        public string TipoCuenta { get; set; }
        public int NroCbu { get; set; }
        public double Saldo { get; set; }
        public int IdCliente { get; set; }

    }
}
