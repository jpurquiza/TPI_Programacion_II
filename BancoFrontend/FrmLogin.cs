using BancoBackend.DataAccess;
using BancoBackend.Cache;
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
using BancoBackend.Entities;
using Newtonsoft.Json;
using System.Net.Http;

namespace BancoFrontend
{
    public partial class FrmLogin : Form
    {

        UserLogin oUsuario = new UserLogin();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            await LoginAsync(oUsuario);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegistro FRegistro = new FrmRegistro() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; ;
            pPrincipal.BringToFront();
            pPrincipal.Controls.Add(FRegistro);
            pPrincipal.Visible = true;
            FRegistro.Show();
        }
        private async Task<bool> LoginAsync(UserLogin oUsuario)
        {

            if (!string.IsNullOrEmpty(txtDNI.Texts))
            {
                if (!string.IsNullOrEmpty(txtClave.Texts))
                {
                    string url = "https://localhost:44328/api/Clientes/login";
                    string loginJson = JsonConvert.SerializeObject(new UserLogin() {DNI = Convert.ToInt32(txtDNI.Texts), Pass = txtClave.Texts });
                    var result = await ClientSingleton.GetInstance().PostAsync(url, loginJson);

                    if (result == "true")
                    {
                        FrmPrincipal principal = new FrmPrincipal() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; ;
                        pPrincipal.BringToFront();
                        pPrincipal.Controls.Add(principal);
                        pPrincipal.Visible = true;
                        principal.Show();
                    }
                    else
                    {
                        MessageBox.Show("Los datos que ingresaste no son correctos. \nPor favor, verificá la información e intentá nuevamente.", "No pudimos validar tus datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtClave.PlaceholderText = "Clave";
                        txtDNI.Focus();
                    }
                }
                else MessageBox.Show("Los datos que ingresaste no son correctos. \nPor favor, verificá la información e intentá nuevamente.", "Debes ingresar tu clave.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Los datos que ingresaste no son correctos. \nPor favor, verificá la información e intentá nuevamente.", "Debes ingresar tu DNI.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return true;
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
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

