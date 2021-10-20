﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.GUI
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
                btnTransaccion.Image = Properties.Resources.comprime;
                PanelTransaccionDropDown.Height += 10;
                if (PanelTransaccionDropDown.Size == PanelTransaccionDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                btnTransaccion.Image = Properties.Resources.amplia;
                PanelTransaccionDropDown.Height -= 10;
                if (PanelTransaccionDropDown.Size == PanelTransaccionDropDown.MinimumSize)
                {
                    timer1.Stop();
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
            
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNvaTransferencia_Click(object sender, EventArgs e)
        {
            FrmNuevaTransferencia frmNuevaTransf = new FrmNuevaTransferencia() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pContainer.Controls.Add(frmNuevaTransf);
            pContainer.Visible = true;
            frmNuevaTransf.Show();
        }
    }
}
