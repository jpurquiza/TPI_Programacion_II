using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    class Destinatarios : Persona
    {
        public int IdDestinatario { get; set; }
        public int NroCbu { get; set; }

        public Destinatarios (int idDestinatario, int nroCbu, string nombre, string apellido, int dni, string email) : base(nombre, apellido, dni, email)
        {
            IdDestinatario = idDestinatario;
            NroCbu = nroCbu;
        }


    }
}