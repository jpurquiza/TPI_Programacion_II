using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    class Persona
    {
        public Persona(string nombre, string apellido, int dni, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Email = email;
        }

        public Persona()
        {
                
        }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }

        public string Email { get; set; }


    }
}
