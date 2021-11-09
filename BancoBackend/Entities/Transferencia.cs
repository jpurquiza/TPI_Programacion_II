using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Entities
{
    public class Transferencia
    {
        public string IdCuenta { get; set; }
        public string IdDestinatario { get; set; }
        public string Fecha { get; set; }
        public double Importe { get; set; }
        public string Concepto { get; set; }

        public Transferencia(string idCuenta, string idDestinatario, string fecha, double importe, string concepto)
        {
            IdCuenta = idCuenta;
            IdDestinatario = idDestinatario;
            Fecha = fecha;
            Importe = importe;
            Concepto = concepto;
        }

        public Transferencia()
        {

        }
    }
}
