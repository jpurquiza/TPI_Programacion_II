using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Entities
{
    public class Transferencia
    {
        public int IdCuenta { get; set; }
        public int IdDestinatario { get; set; }
        public string Fecha { get; set; }
        public double Monto { get; set; }
        public string Concepto { get; set; }

        public Transferencia(int idCuenta, int idDestinatario, string fecha, double monto, string concepto)
        {
            IdCuenta = idCuenta;
            IdDestinatario = idDestinatario;
            Fecha = fecha;
            Monto = monto;
            Concepto = concepto;
        }

        public Transferencia() { }
    }
}
