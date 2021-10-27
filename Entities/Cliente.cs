using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    class Cliente : Persona
    {
       
        public int  IdCliente { get; set; }
        public string Clave { get; set; }
        public string IdDestinatario { get; set; }
        public List<Destinatarios> AgendaDestinatarios { get; }
        public List<Cuenta> CuentasClientes { get; set; }



        public Cliente (int idCliente, string clave, string idDestinatario, string nombre , string apellido, int dni, string email):base(nombre, apellido, dni, email)
        {
            IdCliente = idCliente;
            Clave = clave;
            IdDestinatario = idDestinatario;
        }

        public Cliente()
        {
            AgendaDestinatarios = new List<Destinatarios>();
            CuentasClientes = new List<Cuenta>();
        }


    }
}
