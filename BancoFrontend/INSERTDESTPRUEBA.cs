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
                rbtnAgregar.Text = "Editar";
                lblDestinatarios.Text = "Modificar destinatario";

            }
            else
            {
                destinatarioForm = new Destinatarios();
                rbtnAgregar.Text = "Guardar";
                lblDestinatarios.Text = "Nuevo destinatario";
            }

        }

        private async void rbtnAgregar_Click(object sender, EventArgs e)
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


            destinatarioForm.Email = txtEmail.Text;
            destinatarioForm.Nombre = txtNombre.Text;
            destinatarioForm.NroCbu = Convert.ToInt32(txtCBU.Text);
            destinatarioForm.Apellido = txtApellido.Text;
            destinatarioForm.Dni = Convert.ToInt32(txtDNI.Text);

            string data = JsonConvert.SerializeObject(destinatarioForm);
            if (type == 1)
            {

                var success = await ModificarDestinatarioAsync(data);

                if (success)
                {
                    if (MessageBox.Show("¡Destinatario modificado con éxito!", "Confirmación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        LimpiarCampos();
                        Close();
                }
                else
                {
                    if (MessageBox.Show("Ha ocurrido un inconveniente al intentar modificar el destinatario",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        txtCBU.Focus();
                }
            }
            else
            {
                var success = await GrabarDestinatarioAsync(data);

                if (success)
                {
                    if (MessageBox.Show("¡Destinatario registrado con éxito!", "Confirmación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        LimpiarCampos();
                        Close();
                    
                }
                else
                {
                    if (MessageBox.Show("Ha ocurrido un inconveniente al intentar registrar el destinatario",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        txtCBU.Focus();
                }

            }
        }
        //                dgvDestinatarios.Rows.Clear();

        private void rbtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cancelar?",
                "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)

            Close();
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten valores numéricos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCBU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten valores numéricos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }



        //----------------------------------

        /*private async void bntAgregar_Click(object sender, EventArgs e)
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
        }*/

    }
}
