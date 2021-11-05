﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBackend.Entities
{
    public class Destinatarios : Persona
    {
        public int IdDestinatario { get; set; }
        public int NroCbu { get; set; }
        public string CboAux { get; set; }
        public Destinatarios() { }
        public Destinatarios (int idDestinatario, int nroCbu, string cboAux, string nombre, string apellido, int dni, string email) : base(nombre, apellido, dni, email)
        {
            IdDestinatario = idDestinatario;
            NroCbu = nroCbu;
            CboAux = cboAux;
        }


    }
}