using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Dominio
{
    class Cuenta
    {
        public int Cbu { get; set; }
        public double Saldo { get; set; }

        public int TipoCuenta()
        {
            return 0;
        }

        public int UltimoMovimento()
        {
            return 0;
        }
    }
}
