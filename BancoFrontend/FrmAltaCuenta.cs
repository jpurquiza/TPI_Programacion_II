using BancoBackend.DataAccess;
using BancoBackend.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoFrontend
{
    public partial class FrmAltaCuenta : Form
    {
        Cuenta oCuenta;
        public FrmAltaCuenta()
        {
            InitializeComponent();
            oCuenta = new Cuenta();
        }

        private async Task<bool> AltaCuentaAsync(Cuenta oCuenta)
        {
            oCuenta.IdTipoCuenta = Convert.ToInt32(cboTipoCuentas.SelectedValue.ToString()); 

            string url = "https://localhost:44328/api/Clientes/altaCuenta";
            string clienteJson = JsonConvert.SerializeObject(oCuenta);
            var result = await ClientSingleton.GetInstance().PostAsync(url, clienteJson);
            //return result.Equals("true");

            if (result.Equals("true"))
            {
                MessageBox.Show("Se ha registrado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Error al intentar registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

        private async Task CargarCboTiposCuetnasAsync()
        {
            string url = "https://localhost:44328/api/Clientes/tipoCuentas";
            using (HttpClient cliente = new HttpClient())
            {
                var result = await cliente.GetAsync(url);
                var bodyJSON = await result.Content.ReadAsStringAsync();
                List<Cuenta> lst = JsonConvert.DeserializeObject<List<Cuenta>>(bodyJSON);
                cboTipoCuentas.DataSource = lst;
                cboTipoCuentas.ValueMember = "IdTipoCuenta".ToString();
                cboTipoCuentas.DisplayMember = "TipoCuenta";
                cboTipoCuentas.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private async void rbtnConfirmar_Click(object sender, EventArgs e)
        {
            await AltaCuentaAsync(oCuenta);
        }

        private async void FrmAltaCuenta_Load(object sender, EventArgs e)
        {
            await CargarCboTiposCuetnasAsync();
        }

        private void rbtnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
