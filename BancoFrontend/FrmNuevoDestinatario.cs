using BancoBackend.DataAccess;
using BancoBackend.Entities;
using BancoBackend.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoFrontend
{
    public partial class FrmNuevoDestinatario : Form
    {
        private GestorClientes _gestorClientes;
        public FrmNuevoDestinatario()
        {
            InitializeComponent();
            _gestorClientes = new GestorClientes();

        }

        private void rButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dgvDestinatarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FrmNuevoDestinatario_Load(object sender, EventArgs e)
        {
            CargarDestinatarios();
        }

        private void CargarDestinatarios()
        {
            List<Destinatarios> lst = _gestorClientes.GetDestinatarios();

            foreach (Destinatarios oDestinatarios in lst)
            {
                dgvDestinatarios.Rows.Add(new object[] {
                                            oDestinatarios.Nombre,
                                            oDestinatarios.Apellido,
                                            oDestinatarios.Dni,
                                            oDestinatarios.NroCbu,
                                            oDestinatarios.Email
                });
            }
        }

        private void rbtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
