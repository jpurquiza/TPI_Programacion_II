using Banco.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Dominio
{
    class Cliente : Persona
    {
       
        public int  IdCliente { get; set; }

        
        public Cliente (int idCliente, string nombre , string apellido, int dni):base(nombre, apellido, dni)
        {

        }

        public Cliente(int idCliente)
        {
            IdCliente = idCliente;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
