
namespace Banco.GUI
{
    partial class FrmNuevoDestinatario
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
            this.rButton1 = new Banco.Resources.RButton();
            this.btnIngresar = new Banco.Resources.RButton();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.rTxtMail = new Banco.Resources.RTextBox();
            this.rDNI = new Banco.Resources.RTextBox();
            this.rTxtApellido = new Banco.Resources.RTextBox();
            this.rTxtNombre = new Banco.Resources.RTextBox();
            this.rtxtCbu = new Banco.Resources.RTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rButton1);
            this.panel1.Controls.Add(this.btnIngresar);
            this.panel1.Controls.Add(this.lblDestinatario);
            this.panel1.Controls.Add(this.rTxtMail);
            this.panel1.Controls.Add(this.rDNI);
            this.panel1.Controls.Add(this.rTxtApellido);
            this.panel1.Controls.Add(this.rTxtNombre);
            this.panel1.Controls.Add(this.rtxtCbu);
            this.panel1.Location = new System.Drawing.Point(113, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 408);
            this.panel1.TabIndex = 23;
            // 
            // rButton1
            // 
            this.rButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.rButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.rButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rButton1.BorderRadius = 20;
            this.rButton1.BorderSize = 0;
            this.rButton1.FlatAppearance.BorderSize = 0;
            this.rButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rButton1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButton1.ForeColor = System.Drawing.Color.White;
            this.rButton1.Location = new System.Drawing.Point(207, 352);
            this.rButton1.Name = "rButton1";
            this.rButton1.Size = new System.Drawing.Size(47, 32);
            this.rButton1.TabIndex = 21;
            this.rButton1.Text = "X";
            this.rButton1.TextColor = System.Drawing.Color.White;
            this.rButton1.UseVisualStyleBackColor = false;
            this.rButton1.Click += new System.EventHandler(this.rButton1_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Green;
            this.btnIngresar.BackgroundColor = System.Drawing.Color.Green;
            this.btnIngresar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnIngresar.BorderRadius = 20;
            this.btnIngresar.BorderSize = 0;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(34, 352);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(156, 32);
            this.btnIngresar.TabIndex = 20;
            this.btnIngresar.Text = "Aceptar";
            this.btnIngresar.TextColor = System.Drawing.Color.White;
            this.btnIngresar.UseVisualStyleBackColor = false;
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.BackColor = System.Drawing.SystemColors.Control;
            this.lblDestinatario.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinatario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDestinatario.Location = new System.Drawing.Point(55, 25);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(179, 26);
            this.lblDestinatario.TabIndex = 19;
            this.lblDestinatario.Text = "Nuevo Destinatario";
            // 
            // rTxtMail
            // 
            this.rTxtMail.BackColor = System.Drawing.SystemColors.Control;
            this.rTxtMail.BorderColor = System.Drawing.Color.DimGray;
            this.rTxtMail.BorderFocusColor = System.Drawing.Color.Black;
            this.rTxtMail.BorderRadius = 0;
            this.rTxtMail.BorderSize = 1;
            this.rTxtMail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtMail.ForeColor = System.Drawing.Color.DimGray;
            this.rTxtMail.Location = new System.Drawing.Point(47, 269);
            this.rTxtMail.Margin = new System.Windows.Forms.Padding(4);
            this.rTxtMail.Multiline = false;
            this.rTxtMail.Name = "rTxtMail";
            this.rTxtMail.Padding = new System.Windows.Forms.Padding(7);
            this.rTxtMail.PasswordChar = false;
            this.rTxtMail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rTxtMail.PlaceholderText = "e-Mail";
            this.rTxtMail.Size = new System.Drawing.Size(198, 34);
            this.rTxtMail.TabIndex = 18;
            this.rTxtMail.Texts = "";
            this.rTxtMail.UnderlinedStyle = true;
            // 
            // rDNI
            // 
            this.rDNI.BackColor = System.Drawing.SystemColors.Control;
            this.rDNI.BorderColor = System.Drawing.Color.DimGray;
            this.rDNI.BorderFocusColor = System.Drawing.Color.Black;
            this.rDNI.BorderRadius = 0;
            this.rDNI.BorderSize = 1;
            this.rDNI.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rDNI.ForeColor = System.Drawing.Color.DimGray;
            this.rDNI.Location = new System.Drawing.Point(47, 217);
            this.rDNI.Margin = new System.Windows.Forms.Padding(4);
            this.rDNI.Multiline = false;
            this.rDNI.Name = "rDNI";
            this.rDNI.Padding = new System.Windows.Forms.Padding(7);
            this.rDNI.PasswordChar = false;
            this.rDNI.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rDNI.PlaceholderText = "DNI";
            this.rDNI.Size = new System.Drawing.Size(198, 34);
            this.rDNI.TabIndex = 17;
            this.rDNI.Texts = "";
            this.rDNI.UnderlinedStyle = true;
            // 
            // rTxtApellido
            // 
            this.rTxtApellido.BackColor = System.Drawing.SystemColors.Control;
            this.rTxtApellido.BorderColor = System.Drawing.Color.DimGray;
            this.rTxtApellido.BorderFocusColor = System.Drawing.Color.Black;
            this.rTxtApellido.BorderRadius = 0;
            this.rTxtApellido.BorderSize = 1;
            this.rTxtApellido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtApellido.ForeColor = System.Drawing.Color.DimGray;
            this.rTxtApellido.Location = new System.Drawing.Point(47, 175);
            this.rTxtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.rTxtApellido.Multiline = false;
            this.rTxtApellido.Name = "rTxtApellido";
            this.rTxtApellido.Padding = new System.Windows.Forms.Padding(7);
            this.rTxtApellido.PasswordChar = false;
            this.rTxtApellido.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rTxtApellido.PlaceholderText = "Apellido";
            this.rTxtApellido.Size = new System.Drawing.Size(198, 34);
            this.rTxtApellido.TabIndex = 16;
            this.rTxtApellido.Texts = "";
            this.rTxtApellido.UnderlinedStyle = true;
            // 
            // rTxtNombre
            // 
            this.rTxtNombre.BackColor = System.Drawing.SystemColors.Control;
            this.rTxtNombre.BorderColor = System.Drawing.Color.DimGray;
            this.rTxtNombre.BorderFocusColor = System.Drawing.Color.Black;
            this.rTxtNombre.BorderRadius = 0;
            this.rTxtNombre.BorderSize = 1;
            this.rTxtNombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTxtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.rTxtNombre.Location = new System.Drawing.Point(47, 133);
            this.rTxtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.rTxtNombre.Multiline = false;
            this.rTxtNombre.Name = "rTxtNombre";
            this.rTxtNombre.Padding = new System.Windows.Forms.Padding(7);
            this.rTxtNombre.PasswordChar = false;
            this.rTxtNombre.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rTxtNombre.PlaceholderText = "Nombre";
            this.rTxtNombre.Size = new System.Drawing.Size(198, 34);
            this.rTxtNombre.TabIndex = 15;
            this.rTxtNombre.Texts = "";
            this.rTxtNombre.UnderlinedStyle = true;
            // 
            // rtxtCbu
            // 
            this.rtxtCbu.BackColor = System.Drawing.SystemColors.Control;
            this.rtxtCbu.BorderColor = System.Drawing.Color.DimGray;
            this.rtxtCbu.BorderFocusColor = System.Drawing.Color.Black;
            this.rtxtCbu.BorderRadius = 0;
            this.rtxtCbu.BorderSize = 1;
            this.rtxtCbu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtCbu.ForeColor = System.Drawing.Color.DimGray;
            this.rtxtCbu.Location = new System.Drawing.Point(47, 79);
            this.rtxtCbu.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtCbu.Multiline = false;
            this.rtxtCbu.Name = "rtxtCbu";
            this.rtxtCbu.Padding = new System.Windows.Forms.Padding(7);
            this.rtxtCbu.PasswordChar = false;
            this.rtxtCbu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rtxtCbu.PlaceholderText = "CBU";
            this.rtxtCbu.Size = new System.Drawing.Size(198, 34);
            this.rtxtCbu.TabIndex = 14;
            this.rtxtCbu.Texts = "";
            this.rtxtCbu.UnderlinedStyle = true;
            // 
            // FrmNuevoDestinatario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Banco.Properties.Resources.login_background_2;
            this.ClientSize = new System.Drawing.Size(542, 466);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNuevoDestinatario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNuevoDestinatario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDestinatario;
        private Resources.RTextBox rTxtMail;
        private Resources.RTextBox rDNI;
        private Resources.RTextBox rTxtApellido;
        private Resources.RTextBox rTxtNombre;
        private Resources.RTextBox rtxtCbu;
        private Resources.RButton rButton1;
        private Resources.RButton btnIngresar;
    }
}