
namespace BancoFrontend
{
    partial class FrmRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new BancoFrontend.Resources.RButton();
            this.btnRegistrarse = new BancoFrontend.Resources.RButton();
            this.txtEmail = new BancoFrontend.Resources.RTextBox();
            this.txtDNI = new BancoFrontend.Resources.RTextBox();
            this.txtApellido = new BancoFrontend.Resources.RTextBox();
            this.txtNombre = new BancoFrontend.Resources.RTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnRegistrarse);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtDNI);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Location = new System.Drawing.Point(120, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 368);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(72, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 46);
            this.label1.TabIndex = 20;
            this.label1.Text = "¡Bienvenido a MiCuenta!\r\nPor favor completa los siguientes datos para poder crear" +
    " tu cuenta.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 15;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(344, 280);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(168, 38);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = " Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.rbtnCancelar_Click);
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(164)))), ((int)(((byte)(84)))));
            this.btnRegistrarse.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(164)))), ((int)(((byte)(84)))));
            this.btnRegistrarse.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRegistrarse.BorderRadius = 15;
            this.btnRegistrarse.BorderSize = 0;
            this.btnRegistrarse.FlatAppearance.BorderSize = 0;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarse.Location = new System.Drawing.Point(152, 280);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(168, 38);
            this.btnRegistrarse.TabIndex = 18;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.TextColor = System.Drawing.Color.White;
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_ClickAsync);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txtEmail.BorderRadius = 0;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(344, 200);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(8);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(184, 36);
            this.txtEmail.TabIndex = 17;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = true;
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.SystemColors.Control;
            this.txtDNI.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txtDNI.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txtDNI.BorderRadius = 0;
            this.txtDNI.BorderSize = 2;
            this.txtDNI.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDNI.ForeColor = System.Drawing.Color.DimGray;
            this.txtDNI.Location = new System.Drawing.Point(136, 200);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(5);
            this.txtDNI.Multiline = false;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Padding = new System.Windows.Forms.Padding(8);
            this.txtDNI.PasswordChar = false;
            this.txtDNI.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDNI.PlaceholderText = "DNI";
            this.txtDNI.Size = new System.Drawing.Size(184, 36);
            this.txtDNI.TabIndex = 16;
            this.txtDNI.Texts = "";
            this.txtDNI.UnderlinedStyle = true;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.Control;
            this.txtApellido.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txtApellido.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txtApellido.BorderRadius = 0;
            this.txtApellido.BorderSize = 2;
            this.txtApellido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellido.Location = new System.Drawing.Point(344, 136);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(5);
            this.txtApellido.Multiline = false;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Padding = new System.Windows.Forms.Padding(8);
            this.txtApellido.PasswordChar = false;
            this.txtApellido.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtApellido.PlaceholderText = "Apellido";
            this.txtApellido.Size = new System.Drawing.Size(184, 36);
            this.txtApellido.TabIndex = 15;
            this.txtApellido.Texts = "";
            this.txtApellido.UnderlinedStyle = true;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombre.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.txtNombre.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txtNombre.BorderRadius = 0;
            this.txtNombre.BorderSize = 2;
            this.txtNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(136, 136);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(8);
            this.txtNombre.PasswordChar = false;
            this.txtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.Size = new System.Drawing.Size(184, 36);
            this.txtNombre.TabIndex = 14;
            this.txtNombre.Texts = "";
            this.txtNombre.UnderlinedStyle = true;
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BancoFrontend.Properties.Resources.background_register;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Resources.RTextBox txtEmail;
        private Resources.RTextBox txtDNI;
        private Resources.RTextBox txtApellido;
        private Resources.RTextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private Resources.RButton btnCancelar;
        private Resources.RButton btnRegistrarse;
    }
}