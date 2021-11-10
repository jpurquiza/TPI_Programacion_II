
namespace BancoFrontend
{
    partial class INSERTDESTPRUEBA
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCBU = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnCancelar = new BancoFrontend.Resources.RButton();
            this.rbtnAgregar = new BancoFrontend.Resources.RButton();
            this.lblDestinatarios = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "CBU";
            // 
            // txtCBU
            // 
            this.txtCBU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCBU.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCBU.Location = new System.Drawing.Point(147, 74);
            this.txtCBU.Name = "txtCBU";
            this.txtCBU.Size = new System.Drawing.Size(100, 23);
            this.txtCBU.TabIndex = 1;
            this.txtCBU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCBU_KeyPress);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(147, 120);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 23);
            this.txtDNI.TabIndex = 2;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(75, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "DNI";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(147, 163);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(75, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(147, 206);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 23);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(75, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(147, 244);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(75, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnCancelar);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.rbtnAgregar);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.lblDestinatarios);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.txtCBU);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDNI);
            this.panel1.Location = new System.Drawing.Point(232, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 392);
            this.panel1.TabIndex = 19;
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
            this.rbtnCancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnCancelar.ForeColor = System.Drawing.Color.White;
            this.rbtnCancelar.Location = new System.Drawing.Point(184, 318);
            this.rbtnCancelar.Name = "rbtnCancelar";
            this.rbtnCancelar.Size = new System.Drawing.Size(126, 38);
            this.rbtnCancelar.TabIndex = 7;
            this.rbtnCancelar.Text = " Cancelar";
            this.rbtnCancelar.TextColor = System.Drawing.Color.White;
            this.rbtnCancelar.UseVisualStyleBackColor = false;
            this.rbtnCancelar.Click += new System.EventHandler(this.rbtnCancelar_Click);
            // 
            // rbtnAgregar
            // 
            this.rbtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(164)))), ((int)(((byte)(84)))));
            this.rbtnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(164)))), ((int)(((byte)(84)))));
            this.rbtnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rbtnAgregar.BorderRadius = 15;
            this.rbtnAgregar.BorderSize = 0;
            this.rbtnAgregar.FlatAppearance.BorderSize = 0;
            this.rbtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnAgregar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnAgregar.ForeColor = System.Drawing.Color.White;
            this.rbtnAgregar.Location = new System.Drawing.Point(32, 318);
            this.rbtnAgregar.Name = "rbtnAgregar";
            this.rbtnAgregar.Size = new System.Drawing.Size(126, 38);
            this.rbtnAgregar.TabIndex = 6;
            this.rbtnAgregar.Text = "Agregar";
            this.rbtnAgregar.TextColor = System.Drawing.Color.White;
            this.rbtnAgregar.UseVisualStyleBackColor = false;
            this.rbtnAgregar.Click += new System.EventHandler(this.rbtnAgregar_Click);
            // 
            // lblDestinatarios
            // 
            this.lblDestinatarios.AutoSize = true;
            this.lblDestinatarios.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDestinatarios.Location = new System.Drawing.Point(85, 23);
            this.lblDestinatarios.Name = "lblDestinatarios";
            this.lblDestinatarios.Size = new System.Drawing.Size(162, 23);
            this.lblDestinatarios.TabIndex = 21;
            this.lblDestinatarios.Text = "Nuevo destinatario";
            this.lblDestinatarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // INSERTDESTPRUEBA
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::BancoFrontend.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "INSERTDESTPRUEBA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INSERTDESTPRUEBA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCBU;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDestinatarios;
        private Resources.RButton rbtnAgregar;
        private Resources.RButton rbtnCancelar;
    }
}