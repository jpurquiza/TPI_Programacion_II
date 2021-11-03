using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using BancoBackend.DataAccess;
using BancoBackend.Entities;
using BancoBackend.Servicios;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace BancoFrontend
{
    public partial class FrmNuevaTransferencia : Form
    {
        public FrmNuevaTransferencia()
        {
            InitializeComponent();
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
        private async void FrmNuevaTransferencia_Load(object sender, EventArgs e)
        {
            await CargarCboDestinatariosAsync();
            await CargarCboCuetnasAsync();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private async Task CargarCboCuetnasAsync()
        {
            string url = "https://localhost:44328/api/Clientes/cuentas";
            using (HttpClient cliente = new HttpClient())
            {
                var result = await cliente.GetAsync(url);
                var bodyJSON = await result.Content.ReadAsStringAsync();
                List<Cuenta> lst = JsonConvert.DeserializeObject<List<Cuenta>>(bodyJSON);
                cboOrigen.DataSource = lst;
                cboOrigen.ValueMember = "IdCuenta";
                cboOrigen.DisplayMember = "TipoCuenta";
            }
        }

        private async Task CargarCboDestinatariosAsync()
        {
            string url = "https://localhost:44328/api/Clientes/destinatarios";
            using (HttpClient cliente = new HttpClient())
            {
                var result = await cliente.GetAsync(url);
                var bodyJSON = await result.Content.ReadAsStringAsync();
                List<Destinatarios> lst = JsonConvert.DeserializeObject<List<Destinatarios>>(bodyJSON);
                cboDestinatario.DataSource = lst;
                cboDestinatario.ValueMember = "IdDestinatario";
                cboDestinatario.DisplayMember = "Apellido";
            }
        }


    }
}
