using System;
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
    public partial class FrmNuevaTransferencia : Form
    {
        public FrmNuevaTransferencia()
        {
            InitializeComponent();
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

        private void rbtnConfirmar_Click(object sender, EventArgs e)
        {
            
        }

        private void rbtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
