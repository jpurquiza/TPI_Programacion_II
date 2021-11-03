
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
            this.rbtnCancelar = new BancoFrontend.Resources.RButton();
            this.rbtnConfirmar = new BancoFrontend.Resources.RButton();
            this.rTextBox3 = new BancoFrontend.Resources.RTextBox();
            this.rTextBox2 = new BancoFrontend.Resources.RTextBox();
            this.rTextBox1 = new BancoFrontend.Resources.RTextBox();
            this.txtDNI = new BancoFrontend.Resources.RTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbtnCancelar);
            this.panel1.Controls.Add(this.rbtnConfirmar);
            this.panel1.Controls.Add(this.rTextBox3);
            this.panel1.Controls.Add(this.rTextBox2);
            this.panel1.Controls.Add(this.rTextBox1);
            this.panel1.Controls.Add(this.txtDNI);
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
            // rbtnCancelar
            // 
            this.rbtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.rbtnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.rbtnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rbtnCancelar.BorderRadius = 15;
            this.rbtnCancelar.BorderSize = 0;
            this.rbtnCancelar.FlatAppearance.BorderSize = 0;
            this.rbtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnCancelar.ForeColor = System.Drawing.Color.White;
            this.rbtnCancelar.Location = new System.Drawing.Point(344, 280);
            this.rbtnCancelar.Name = "rbtnCancelar";
            this.rbtnCancelar.Size = new System.Drawing.Size(168, 38);
            this.rbtnCancelar.TabIndex = 19;
            this.rbtnCancelar.Text = " Cancelar";
            this.rbtnCancelar.TextColor = System.Drawing.Color.White;
            this.rbtnCancelar.UseVisualStyleBackColor = false;
            this.rbtnCancelar.Click += new System.EventHandler(this.rbtnCancelar_Click);
            // 
            // rbtnConfirmar
            // 
            this.rbtnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(164)))), ((int)(((byte)(84)))));
            this.rbtnConfirmar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(164)))), ((int)(((byte)(84)))));
            this.rbtnConfirmar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rbtnConfirmar.BorderRadius = 15;
            this.rbtnConfirmar.BorderSize = 0;
            this.rbtnConfirmar.FlatAppearance.BorderSize = 0;
            this.rbtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnConfirmar.ForeColor = System.Drawing.Color.White;
            this.rbtnConfirmar.Location = new System.Drawing.Point(152, 280);
            this.rbtnConfirmar.Name = "rbtnConfirmar";
            this.rbtnConfirmar.Size = new System.Drawing.Size(168, 38);
            this.rbtnConfirmar.TabIndex = 18;
            this.rbtnConfirmar.Text = "Registrarse";
            this.rbtnConfirmar.TextColor = System.Drawing.Color.White;
            this.rbtnConfirmar.UseVisualStyleBackColor = false;
            // 
            // rTextBox3
            // 
            this.rTextBox3.BackColor = System.Drawing.SystemColors.Control;
            this.rTextBox3.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.rTextBox3.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.rTextBox3.BorderRadius = 0;
            this.rTextBox3.BorderSize = 2;
            this.rTextBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.rTextBox3.Location = new System.Drawing.Point(344, 200);
            this.rTextBox3.Margin = new System.Windows.Forms.Padding(5);
            this.rTextBox3.Multiline = false;
            this.rTextBox3.Name = "rTextBox3";
            this.rTextBox3.Padding = new System.Windows.Forms.Padding(8);
            this.rTextBox3.PasswordChar = false;
            this.rTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rTextBox3.PlaceholderText = "Email";
            this.rTextBox3.Size = new System.Drawing.Size(184, 36);
            this.rTextBox3.TabIndex = 17;
            this.rTextBox3.Texts = "";
            this.rTextBox3.UnderlinedStyle = true;
            // 
            // rTextBox2
            // 
            this.rTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.rTextBox2.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.rTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.rTextBox2.BorderRadius = 0;
            this.rTextBox2.BorderSize = 2;
            this.rTextBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.rTextBox2.Location = new System.Drawing.Point(136, 200);
            this.rTextBox2.Margin = new System.Windows.Forms.Padding(5);
            this.rTextBox2.Multiline = false;
            this.rTextBox2.Name = "rTextBox2";
            this.rTextBox2.Padding = new System.Windows.Forms.Padding(8);
            this.rTextBox2.PasswordChar = false;
            this.rTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rTextBox2.PlaceholderText = "DNI";
            this.rTextBox2.Size = new System.Drawing.Size(184, 36);
            this.rTextBox2.TabIndex = 16;
            this.rTextBox2.Texts = "";
            this.rTextBox2.UnderlinedStyle = true;
            // 
            // rTextBox1
            // 
            this.rTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.rTextBox1.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.rTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.rTextBox1.BorderRadius = 0;
            this.rTextBox1.BorderSize = 2;
            this.rTextBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rTextBox1.Location = new System.Drawing.Point(344, 136);
            this.rTextBox1.Margin = new System.Windows.Forms.Padding(5);
            this.rTextBox1.Multiline = false;
            this.rTextBox1.Name = "rTextBox1";
            this.rTextBox1.Padding = new System.Windows.Forms.Padding(8);
            this.rTextBox1.PasswordChar = false;
            this.rTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rTextBox1.PlaceholderText = "Apellido";
            this.rTextBox1.Size = new System.Drawing.Size(184, 36);
            this.rTextBox1.TabIndex = 15;
            this.rTextBox1.Texts = "";
            this.rTextBox1.UnderlinedStyle = true;
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
            this.txtDNI.Location = new System.Drawing.Point(136, 136);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(5);
            this.txtDNI.Multiline = false;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Padding = new System.Windows.Forms.Padding(8);
            this.txtDNI.PasswordChar = false;
            this.txtDNI.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDNI.PlaceholderText = "Nombre";
            this.txtDNI.Size = new System.Drawing.Size(184, 36);
            this.txtDNI.TabIndex = 14;
            this.txtDNI.Texts = "";
            this.txtDNI.UnderlinedStyle = true;
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
        private Resources.RTextBox rTextBox3;
        private Resources.RTextBox rTextBox2;
        private Resources.RTextBox rTextBox1;
        private Resources.RTextBox txtDNI;
        private System.Windows.Forms.Label label1;
        private Resources.RButton rbtnCancelar;
        private Resources.RButton rbtnConfirmar;
    }
}