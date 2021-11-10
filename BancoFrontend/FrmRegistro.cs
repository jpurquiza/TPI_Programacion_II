using BancoBackend.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using BancoBackend.Entities;
using Newtonsoft.Json;

namespace BancoFrontend
{
    public partial class FrmRegistro : Form
    {
        Cliente oCLiente = new Cliente();

        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void rbtnCancelar_Click(object sender, EventArgs e)
        {
            FrmLogin FLogin = new FrmLogin();
            this.Dispose();
            FLogin.Show();
        }

        private async void btnRegistrarse_ClickAsync(object sender, EventArgs e)
        {
             await AltaClienteAsync(oCLiente);
        }

        private async Task<bool> AltaClienteAsync(Cliente oCliente)
        {
            oCliente.Dni = Convert.ToInt32(txtDNI.Texts);
            oCliente.Apellido = txtApellido.Texts;
            oCliente.Nombre = txtNombre.Texts;
            oCliente.Email = txtEmail.Texts;

            string url = "https://localhost:44328/api/Clientes/altaCliente";
            string clienteJson = JsonConvert.SerializeObject(oCliente);
            var result = await ClientSingleton.GetInstance().PostAsync(url, clienteJson);
            //return result.Equals("true");

            if (result.Equals("true"))
            {
                MessageBox.Show("Se ha registrado con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmLogin FLogin = new FrmLogin();
                this.Dispose();
                FLogin.Show();

            }
            else
            {
                MessageBox.Show("Error al intentar registrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
    }
}