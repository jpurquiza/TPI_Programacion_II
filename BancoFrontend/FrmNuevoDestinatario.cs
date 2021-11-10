using BancoBackend.DataAccess;
using BancoBackend.Entities;
using BancoBackend.Servicios;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoFrontend
{
    public partial class FrmNuevoDestinatario : Form
    {
        private GestorClientes _gestorClientes;
        List<Destinatarios> lst;

        public FrmNuevoDestinatario()
        {
            InitializeComponent();
            _gestorClientes = new GestorClientes();

        }

        private async void FrmNuevoDestinatario_Load(object sender, EventArgs e)
        {
           await CargarDestinatario();
        }   

        private async void add_FormClosed(object sender, FormClosedEventArgs e)
        {
          await  CargarDestinatario();
        }

        private async void dgvDestinatarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDestinatarios.CurrentCell.ColumnIndex == 5)
            {
                var destinatario = lst[dgvDestinatarios.CurrentCell.RowIndex];

                INSERTDESTPRUEBA principal = new INSERTDESTPRUEBA(destinatario, 1);



                principal.FormClosed += add_FormClosed;
                principal.Show();

                //   q esta pasando akiiii
            }

            if (dgvDestinatarios.CurrentCell.ColumnIndex == 6)
            {
                var destinatario = lst[dgvDestinatarios.CurrentCell.RowIndex];
                //eliminado 
                var result = await EliminarDestinatarioAsync(destinatario.IdDestinatario.ToString());
                if (result)
                {
                    MessageBox.Show("No se ha podido eliminar el destinatario, intente nuevamente",
                    "Operación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Destinatario eliminado correctamente",
                    "Operación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            
            CargarDestinatario();
        }


        private async Task CargarDestinatario()
        {

            string url = "https://localhost:44328/api/Clientes/destinatarios";

            var resultado = await ClientSingleton.GetInstance().GetAsync(url);

            lst = JsonConvert.DeserializeObject<List<Destinatarios>>(resultado);


            dgvDestinatarios.Rows.Clear();
            foreach (Destinatarios oDestinatario in lst)
            {
                dgvDestinatarios.Rows.Add(new object[]
                {
                     oDestinatario.Nombre,
                     oDestinatario.Apellido,
                     oDestinatario.Dni,
                     oDestinatario.NroCbu,
                     oDestinatario.Email
                }); ;
            }
            return;
        }

        private async Task<bool> EliminarDestinatarioAsync(string id)
        {
            string url = "https://localhost:44328/api/Clientes/"+id;

            using (HttpClient client = new HttpClient())
            {
                var result = await client.DeleteAsync(url);
                string response = await result.Content.ReadAsStringAsync();
                return response.Equals("Ok");
            }
        }





        private void rButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void rbtnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rbtnAgregar_Click(object sender, EventArgs e)
        {
            INSERTDESTPRUEBA principal = new INSERTDESTPRUEBA(null,2);

            principal.FormClosed += add_FormClosed;
            principal.Show();

        }
    }
}
