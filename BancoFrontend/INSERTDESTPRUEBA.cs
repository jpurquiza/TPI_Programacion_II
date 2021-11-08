using BancoBackend.Entities;
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
    public partial class INSERTDESTPRUEBA : Form
    {
        private Destinatarios destinatarioForm;
        int type;
        public INSERTDESTPRUEBA(Destinatarios destinatario,int type)
        {
            InitializeComponent();
            this.type = type;
            if (type == 1)
            {

                destinatarioForm = destinatario;
                txtCBU.Text = destinatario.NroCbu.ToString();
                txtNombre.Text = destinatario.Nombre;
                txtApellido.Text = destinatario.Apellido;
                txtEmail.Text = destinatario.Email;
                txtDNI.Text = destinatario.Dni.ToString();
                bntAgregar.Text = "Editar";
            }
            else
            {
                destinatarioForm = new Destinatarios();
            }

        }

        void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }


        private async void bntAgregar_Click(object sender, EventArgs e)
        {
            var cbuNumber = int.TryParse(txtCBU.Text, out int n);
            var dniNumber = int.TryParse(txtDNI.Text, out int n1);

            if (!cbuNumber && !dniNumber)
            {
                MessageBox.Show("Ingrese valores numericos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtCBU.Text) || string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Es necesario un CBU y al menos un nombre para continuar",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            destinatarioForm.Email=txtEmail.Text;
            destinatarioForm.Nombre = txtNombre.Text;
            destinatarioForm.NroCbu = Convert.ToInt32(txtCBU.Text);
            destinatarioForm.Apellido = txtApellido.Text;
            destinatarioForm.Dni = Convert.ToInt32(txtDNI.Text);

            string data = JsonConvert.SerializeObject(destinatarioForm);
            if(type == 1)
            {
                bntAgregar.Text = "Modificar";

                var success = await ModificarDestinatarioAsync(data);

                if (success)
                {
                    MessageBox.Show("¡Destinatario modificado con éxito!", "Confirmación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un inconveniente al modificar el destinatario",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                var success = await GrabarDestinatarioAsync(data);

                if (success)
                {
                    MessageBox.Show("¡Destinatario registrado con éxito!", "Confirmación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un inconveniente al registrar el destinatario",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void LimpiarCampos()
        {
            txtCBU.Text = string.Empty;
            txtCBU.Focus();
            txtDNI.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private async Task<bool> GrabarDestinatarioAsync(string data)
        {
            string url = "https://localhost:44328/api/Clientes/altaDestinatario";

            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(url, content);
                string response = await result.Content.ReadAsStringAsync();
                return response.Equals("Ok");
            }
        }
        private async Task<bool> ModificarDestinatarioAsync(string data)
        {
            string url = "https://localhost:44328/api/Clientes/modificarDestinatario";

            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
                var result = await client.PostAsync(url, content);
                string response = await result.Content.ReadAsStringAsync();
                return response.Equals("Ok");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar?",
                "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Dispose();
        }


    }
}
