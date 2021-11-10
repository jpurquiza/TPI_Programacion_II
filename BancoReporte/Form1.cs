using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BancoReporte
{
    public partial class frmMovimientos : Form
    {
        public frmMovimientos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsMovimientos._dsMovimientos' Puede moverla o quitarla según sea necesario.
            this.dsMovimientosTableAdapter.Fill(this.dsMovimientos._dsMovimientos);
            // TODO: esta línea de código carga datos en la tabla 'dsMovimientos1._dsMovimientos' Puede moverla o quitarla según sea necesario.
        //    this.dsMovimientosTableAdapter.Fill(this.dsMovimientos1._dsMovimientos);
        //TODO: esta línea de código carga datos en la tabla 'dsMovimientos.dsMovimientos' Puede moverla o quitarla según sea necesario.
        //    this.dsMovimientosTableAdapter.Fill(this.dsMovimientos.dsMovimientos);
            //SqlConnection cnn = new SqlConnection(@"Data Source =DESKTOP-3TFHJBS\SQLEXPRESS01; Initial Catalog = db_banco; Integrated Security = True");

            //DataTable table = new DataTable();
            //cnn.Open();
            //SqlCommand cmd = new SqlCommand("SP_CONSULTAR_TRANSACCIONES", cnn);
            //cmd.CommandType = CommandType.StoredProcedure;

            //table.Load(cmd.ExecuteReader());
            //cnn.Close();


            //rvMovimientos.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", table));


            this.rvMovimientos.RefreshReport();
        }

        private void dsMovimientosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
