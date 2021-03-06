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
            timer3.Enabled = true;
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

        private void btnAltaCuenta_Click(object sender, EventArgs e)
        {
            FrmAltaCuenta frmAltaCuenta = new FrmAltaCuenta() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pContainer.Controls.Add(frmAltaCuenta);
            pContainer.Visible = true;
            frmAltaCuenta.Show();
        }

        private void btnAltaTC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por el momento no podemos ofrecerte este producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAltaPrestamo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Por el momento no podemos ofrecerte este producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAcercaDe frmAcercaDe = new FrmAcercaDe() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pContainer.Controls.Add(frmAcercaDe);
            pContainer.Visible = true;
            frmAcercaDe.Show();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {


        }
    }
}
