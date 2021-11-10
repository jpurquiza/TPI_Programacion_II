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
            await GrabarTransferenciaAsync(oTransferencia);

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
                cboOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
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
                cboDestinatario.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }
        
        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten valores numéricos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private async Task<bool> GrabarTransferenciaAsync(Transferencia oTransferencia)
        {
            oTransferencia.IdCuenta = Convert.ToInt32(cboOrigen.SelectedValue.ToString());
            oTransferencia.IdDestinatario = Convert.ToInt32(cboDestinatario.SelectedValue.ToString());
            oTransferencia.Fecha = DateTime.Now.ToString("dd/MM/yyyy");
            oTransferencia.Monto = Convert.ToDouble(txtImporte.Texts);
            oTransferencia.Concepto = txtConcepto.Texts;

            string url = "https://localhost:44328/api/Clientes/altaTransferencia";
            string transferenciaJson = JsonConvert.SerializeObject(oTransferencia);
            var result = await ClientSingleton.GetInstance().PostAsync(url, transferenciaJson);

            if (result == "true")
            {
                MessageBox.Show("La transferencia se realizó exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await CargarCboCuetnasAsync();
                await CargarCboCuetnasAsync();
            }
            else
            {
                MessageBox.Show("Error al intentar realizar la transferencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
    }
}
