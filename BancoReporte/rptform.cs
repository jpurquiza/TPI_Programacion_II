using BancoReporte.BDpruebaDSTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoReporte
{
    public partial class rptform : Form
    {
        public rptform()
        {
            InitializeComponent();
        }

        private void rptform_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BDpruebaDS.SP_CONSLULTAR_TRANSACCIONES' Puede moverla o quitarla según sea necesario.
            //this.SP_CONSLULTAR_TRANSACCIONESTableAdapter.Fill(this.BDpruebaDS.SP_CONSLULTAR_TRANSACCIONES);

            //this.reportViewer1.RefreshReport();
        }

        public void filtroDDatos(int z, DateTime x, DateTime y)
        {
            try
            {
                //TableTableAdapter.Fill(BDpruebaDS.SP_CONSLULTAR_TRANSACCIONES, z, x, y );
                //reportViewer1.RefreshReport();
                //this.Show();

                SP_CONSLULTAR_TRANSACCIONESTableAdapter Table = new SP_CONSLULTAR_TRANSACCIONESTableAdapter();
                Table.Fill(BDpruebaDS.SP_CONSLULTAR_TRANSACCIONES, z, x, y);
                reportViewer1.RefreshReport();
                this.Show();


            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
