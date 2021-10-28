using System;
using System.Collections.Generic;
using BackendBanco.DataAccess;
using BackendBanco.Entities;
using BackendBanco.Servicios;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.GUI
{
    public partial class FrmNuevaTransferencia : Form
    {
        private GestorClientes _gestorClientes;
        public FrmNuevaTransferencia()
        {
            InitializeComponent();
            _gestorClientes = new GestorClientes(new ClienteDaoFactory());
        }

        private void rbtnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregarDest_Click(object sender, EventArgs e)
        {
            FrmNuevoDestinatario destNuevo = new FrmNuevoDestinatario();
            destNuevo.ShowDialog();
        }

        private void rbtnConfirmar_Click(object sender, EventArgs e)
        {
            
        }

        private void rbtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void FrmNuevaTransferencia_Load(object sender, EventArgs e)
        {
            CargarCboCuentas();
        }
        private void CargarCboCuentas()
        {
            List<Cuenta> lst = _gestorClientes.GetCuentas();

            cboOrigen.DataSource = lst;
            cboOrigen.ValueMember = "IdCuenta";
            cboOrigen.DisplayMember = "TipoCuenta";
            string saldo = "Saldo";
            lblSaldo.Text = "Saldo disponble $" + saldo;

        }


    }
}
