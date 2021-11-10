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
    public partial class FrmFiltros : Form
    {
        public FrmFiltros()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int pk = Convert.ToInt32(cboClientes.SelectedValue.ToString());

            DateTime  fec1 = DateTime.Parse(dateTimePicker1.Text);
            DateTime fec2 = DateTime.Parse(dateTimePicker2.Text);

            rptform obj = new rptform();
            obj.filtroDDatos(pk, fec1, fec2);




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void CargarClientes()
        {

            SqlConnection cnn = new SqlConnection(@"Data Source =DESKTOP-3TFHJBS\SQLEXPRESS01;Initial Catalog =banco;Integrated Security = True");

            cnn.Open();
            DataTable tabla = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM clientes";
            cmd.Connection = cnn;
            tabla.Load(cmd.ExecuteReader());
            cnn.Close();

            cboClientes.DataSource = tabla;
            cboClientes.ValueMember = tabla.Columns[0].ColumnName; //"idMarca"
            cboClientes.DisplayMember = tabla.Columns[3].ColumnName;//"nombreMarca"

        }

        private void FrmFiltros_Load(object sender, EventArgs e)
        {

            CargarClientes();
        }
    }
}
