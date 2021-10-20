
namespace Banco.GUI
{
    partial class FrmNuevaTransferencia
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
            this.rbtnCancelar = new Banco.Resources.RButton();
            this.rbtnConfirmar = new Banco.Resources.RButton();
            this.btnAgregarDest = new Banco.Resources.RButton();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.cboDestinatario = new System.Windows.Forms.ComboBox();
            this.cboOrigen = new System.Windows.Forms.ComboBox();
            this.txtConcepto = new Banco.Resources.RTextBox();
            this.txtImporte = new Banco.Resources.RTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnCancelar);
            this.panel1.Controls.Add(this.rbtnConfirmar);
            this.panel1.Controls.Add(this.btnAgregarDest);
            this.panel1.Controls.Add(this.lblSaldo);
            this.panel1.Controls.Add(this.cboDestinatario);
            this.panel1.Controls.Add(this.cboOrigen);
            this.panel1.Controls.Add(this.txtConcepto);
            this.panel1.Controls.Add(this.txtImporte);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(160, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 416);
            this.panel1.TabIndex = 20;
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
            this.rbtnCancelar.Location = new System.Drawing.Point(200, 360);
            this.rbtnCancelar.Name = "rbtnCancelar";
            this.rbtnCancelar.Size = new System.Drawing.Size(168, 38);
            this.rbtnCancelar.TabIndex = 8;
            this.rbtnCancelar.Text = " Cancelar";
            this.rbtnCancelar.TextColor = System.Drawing.Color.White;
            this.rbtnCancelar.UseVisualStyleBackColor = false;
            this.rbtnCancelar.Click += new System.EventHandler(this.rbtnCancelar_Click_1);
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
            this.rbtnConfirmar.Location = new System.Drawing.Point(16, 360);
            this.rbtnConfirmar.Name = "rbtnConfirmar";
            this.rbtnConfirmar.Size = new System.Drawing.Size(168, 38);
            this.rbtnConfirmar.TabIndex = 7;
            this.rbtnConfirmar.Text = "Confirmar";
            this.rbtnConfirmar.TextColor = System.Drawing.Color.White;
            this.rbtnConfirmar.UseVisualStyleBackColor = false;
            this.rbtnConfirmar.Click += new System.EventHandler(this.rbtnConfirmar_Click);
            // 
            // btnAgregarDest
            // 
            this.btnAgregarDest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(152)))));
            this.btnAgregarDest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(152)))));
            this.btnAgregarDest.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregarDest.BorderRadius = 15;
            this.btnAgregarDest.BorderSize = 0;
            this.btnAgregarDest.FlatAppearance.BorderSize = 0;
            this.btnAgregarDest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDest.ForeColor = System.Drawing.Color.White;
            this.btnAgregarDest.Location = new System.Drawing.Point(112, 296);
            this.btnAgregarDest.Name = "btnAgregarDest";
            this.btnAgregarDest.Size = new System.Drawing.Size(150, 30);
            this.btnAgregarDest.TabIndex = 6;
            this.btnAgregarDest.Text = "Nuevo destinatario";
            this.btnAgregarDest.TextColor = System.Drawing.Color.White;
            this.btnAgregarDest.UseVisualStyleBackColor = false;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(152)))));
            this.lblSaldo.Location = new System.Drawing.Point(104, 216);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(102, 15);
            this.lblSaldo.TabIndex = 5;
            this.lblSaldo.Text = "Saldo disponble $";
            // 
            // cboDestinatario
            // 
            this.cboDestinatario.FormattingEnabled = true;
            this.cboDestinatario.Location = new System.Drawing.Point(80, 256);
            this.cboDestinatario.Name = "cboDestinatario";
            this.cboDestinatario.Size = new System.Drawing.Size(224, 27);
            this.cboDestinatario.TabIndex = 4;
            this.cboDestinatario.Text = "Seleccionar destinatario...";
            // 
            // cboOrigen
            // 
            this.cboOrigen.FormattingEnabled = true;
            this.cboOrigen.Location = new System.Drawing.Point(80, 176);
            this.cboOrigen.Name = "cboOrigen";
            this.cboOrigen.Size = new System.Drawing.Size(224, 27);
            this.cboOrigen.TabIndex = 3;
            this.cboOrigen.Text = "Seleccionar cuenta origen...";
            // 
            // txtConcepto
            // 
            this.txtConcepto.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtConcepto.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtConcepto.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txtConcepto.BorderRadius = 0;
            this.txtConcepto.BorderSize = 2;
            this.txtConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcepto.ForeColor = System.Drawing.Color.Black;
            this.txtConcepto.Location = new System.Drawing.Point(80, 120);
            this.txtConcepto.Margin = new System.Windows.Forms.Padding(4);
            this.txtConcepto.Multiline = false;
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Padding = new System.Windows.Forms.Padding(7);
            this.txtConcepto.PasswordChar = false;
            this.txtConcepto.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtConcepto.PlaceholderText = "Concepto";
            this.txtConcepto.Size = new System.Drawing.Size(224, 31);
            this.txtConcepto.TabIndex = 2;
            this.txtConcepto.Texts = "";
            this.txtConcepto.UnderlinedStyle = true;
            // 
            // txtImporte
            // 
            this.txtImporte.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtImporte.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtImporte.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.txtImporte.BorderRadius = 0;
            this.txtImporte.BorderSize = 2;
            this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImporte.ForeColor = System.Drawing.Color.DimGray;
            this.txtImporte.Location = new System.Drawing.Point(80, 64);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(4);
            this.txtImporte.Multiline = false;
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Padding = new System.Windows.Forms.Padding(7);
            this.txtImporte.PasswordChar = false;
            this.txtImporte.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtImporte.PlaceholderText = "Importe";
            this.txtImporte.Size = new System.Drawing.Size(224, 31);
            this.txtImporte.TabIndex = 1;
            this.txtImporte.Texts = "";
            this.txtImporte.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "*carga fecha actual*";
            // 
            // FrmNuevaTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Banco.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNuevaTransferencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Nueva Transferencia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Resources.RButton rbtnCancelar;
        private Resources.RButton rbtnConfirmar;
        private Resources.RButton btnAgregarDest;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.ComboBox cboDestinatario;
        private System.Windows.Forms.ComboBox cboOrigen;
        private Resources.RTextBox txtConcepto;
        private Resources.RTextBox txtImporte;
        private System.Windows.Forms.Label label1;
    }
}