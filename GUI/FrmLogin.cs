using BancoFrontend.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class FrmLogin : Form
    {
        //private int ClientExist;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //ClientExist = 0;
            
            if (txtDNI.Texts == "1")
            {
                FrmPrincipal principal = new FrmPrincipal() {TopLevel = false, TopMost = true };
                pPrincipal.BringToFront();
                pPrincipal.Controls.Add(principal);
                pPrincipal.Visible = true;
                principal.Show();
                
            }
            else
            {
                 MessageBox.Show("usted no esta registrado", "Aviso" );
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
