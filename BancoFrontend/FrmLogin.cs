using BancoBackend.DataAccess;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            FrmPrincipal principal = new FrmPrincipal() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; ;
            pPrincipal.BringToFront();
            pPrincipal.Controls.Add(principal);
            pPrincipal.Visible = true;
            principal.Show();
            //    if (!string.IsNullOrEmpty(txtDNI.Texts))
            //    {
            //        if (!string.IsNullOrEmpty(txtClave.Texts))
            //        {
            //            var validLogin = _gestorClientes.Login(Convert.ToInt32(txtDNI.Texts), txtClave.Texts);

            //            if (validLogin == true)
            //            {
            //                FrmPrincipal principal = new FrmPrincipal() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; ;
            //                pPrincipal.BringToFront();
            //                pPrincipal.Controls.Add(principal);
            //                pPrincipal.Visible = true;
            //                principal.Show();
            //            }
            //            else
            //            {
            //                MessageBox.Show("Los datos que ingresaste no son correctos. \nPor favor, verificá la información e intentá nuevamente.", "No pudimos validar tus datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                txtClave.PlaceholderText = "Clave";
            //                txtDNI.Focus();
            //            }
            //        }
            //        else MessageBox.Show("Los datos que ingresaste no son correctos. \nPor favor, verificá la información e intentá nuevamente.", "Debes ingresar tu clave.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else MessageBox.Show("Los datos que ingresaste no son correctos. \nPor favor, verificá la información e intentá nuevamente.", "Debes ingresar tu DNI.", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
