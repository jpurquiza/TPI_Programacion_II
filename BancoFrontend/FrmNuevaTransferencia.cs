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
        Transferencia oTransferencia;
        public FrmNuevaTransferencia()
        {
            InitializeComponent();
            oTransferencia = new Transferencia();
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

        private async void rbtnConfirmar_Click(object sender, EventArgs e)
        {
            await GrabarTransferencia(oTransferencia);
        }

        private async Task<bool> GrabarTransferencia(Transferencia oTransferencia)
        {
            oTransferencia.IdCuenta = cboOrigen.SelectedValue.ToString();
            oTransferencia.IdDestinatario = cboDestinatario.SelectedValue.ToString();
            oTransferencia.Fecha = DateTime.Now.ToString("dd/MM/yyyy");
            oTransferencia.Importe = Convert.ToDouble(txtImporte.Texts);
            oTransferencia.Concepto = txtConcepto.Texts;

            string url = "https://localhost:44328/api/Clientes/altaTransferencia";
            string transferenciaJson = JsonConvert.SerializeObject(oTransferencia);
            var result = await ClientSingleton.GetInstance().PostAsync(url, transferenciaJson);

            if (result == "true")
            {
                MessageBox.Show("Se ha registrado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al intentar registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
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
            await GetProximoIDAsync();
        }

        private async Task GetProximoIDAsync()
        {
            string url = "https://localhost:44328/api/Clientes/proximoID";
            using (HttpClient cliente = new HttpClient())
            {
                var result = await cliente.GetStringAsync(url);
                oTransferencia.IdTransferencia = Int32.Parse(result);
            }
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
                cboDestinatario.DisplayMember = "CboAux";
            }
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
