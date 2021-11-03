using BancoBackend.Cache;
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
    public partial class FrmPrincipal : Form
    {
        private bool isCollapsed = true;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                //btnTransaccion.Image = Properties.Resources.comprime;
                PanelTransaccionDropDown.Height += 10;
                if (PanelTransaccionDropDown.Size == PanelTransaccionDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                //btnTransaccion.Image = Properties.Resources.amplia;
                PanelTransaccionDropDown.Height -= 10;
                if (PanelTransaccionDropDown.Size == PanelTransaccionDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                //btnAltaProductos.Image = Properties.Resources.comprime;
                pnlAltaProductosDD.Height += 10;
                if (pnlAltaProductosDD.Size == pnlAltaProductosDD.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                //btnAltaProductos.Image = Properties.Resources.amplia;
                pnlAltaProductosDD.Height -= 10;
                if (pnlAltaProductosDD.Size == pnlAltaProductosDD.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }

        }

        private void btnTransaccion_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblBienvenido.Text = "Bienvenido\n" +  UserCache.NombreLogin;
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNvaTransferencia_Click(object sender, EventArgs e)
        {
            FrmNuevaTransferencia frmNuevaTransf = new FrmNuevaTransferencia() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pContainer.Controls.Add(frmNuevaTransf);
            pContainer.Visible = true;
            frmNuevaTransf.Show();
        }

        private void btnAltaProductos_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void btnDestinatarios_Click(object sender, EventArgs e)
        {
            FrmNuevoDestinatario frmDestinatarios = new FrmNuevoDestinatario() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pContainer.Controls.Add(frmDestinatarios);
            pContainer.Visible = true;
            frmDestinatarios.Show();
        }
    }
}
