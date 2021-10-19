
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
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConcepto = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.cboOrigen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cboDestinatario = new System.Windows.Forms.ComboBox();
            this.btnAgregarDest = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnCancelar = new Banco.Resources.RButton();
            this.rbtnConfirmar = new Banco.Resources.RButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(13, 221);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(79, 13);
            this.lblDestinatario.TabIndex = 0;
            this.lblDestinatario.Text = "Destinatario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Importe:";
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Location = new System.Drawing.Point(31, 112);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(65, 13);
            this.lblConcepto.TabIndex = 4;
            this.lblConcepto.Text = "Concepto:";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(128, 65);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(175, 20);
            this.txtImporte.TabIndex = 5;
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(128, 109);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(175, 20);
            this.txtConcepto.TabIndex = 7;
            // 
            // cboOrigen
            // 
            this.cboOrigen.FormattingEnabled = true;
            this.cboOrigen.Location = new System.Drawing.Point(128, 148);
            this.cboOrigen.Name = "cboOrigen";
            this.cboOrigen.Size = new System.Drawing.Size(175, 21);
            this.cboOrigen.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cuenta Origen:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSaldo.Location = new System.Drawing.Point(125, 181);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(113, 13);
            this.lblSaldo.TabIndex = 13;
            this.lblSaldo.Text = "Saldo Disponible $";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(46, 23);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 13);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha:";
            // 
            // cboDestinatario
            // 
            this.cboDestinatario.FormattingEnabled = true;
            this.cboDestinatario.Location = new System.Drawing.Point(128, 218);
            this.cboDestinatario.Name = "cboDestinatario";
            this.cboDestinatario.Size = new System.Drawing.Size(175, 21);
            this.cboDestinatario.TabIndex = 17;
            // 
            // btnAgregarDest
            // 
            this.btnAgregarDest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(152)))));
            this.btnAgregarDest.Location = new System.Drawing.Point(128, 254);
            this.btnAgregarDest.Name = "btnAgregarDest";
            this.btnAgregarDest.Size = new System.Drawing.Size(175, 23);
            this.btnAgregarDest.TabIndex = 19;
            this.btnAgregarDest.Text = "Agregar Destinatario";
            this.btnAgregarDest.UseVisualStyleBackColor = true;
            this.btnAgregarDest.Click += new System.EventHandler(this.btnAgregarDest_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnCancelar);
            this.panel1.Controls.Add(this.rbtnConfirmar);
            this.panel1.Controls.Add(this.lblFecha);
            this.panel1.Controls.Add(this.btnAgregarDest);
            this.panel1.Controls.Add(this.cboOrigen);
            this.panel1.Controls.Add(this.txtConcepto);
            this.panel1.Controls.Add(this.txtImporte);
            this.panel1.Controls.Add(this.cboDestinatario);
            this.panel1.Controls.Add(this.lblConcepto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblDestinatario);
            this.panel1.Controls.Add(this.lblSaldo);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(116, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 363);
            this.panel1.TabIndex = 20;
            // 
            // rbtnCancelar
            // 
            this.rbtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.rbtnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.rbtnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rbtnCancelar.BorderRadius = 20;
            this.rbtnCancelar.BorderSize = 0;
            this.rbtnCancelar.FlatAppearance.BorderSize = 0;
            this.rbtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnCancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCancelar.ForeColor = System.Drawing.Color.White;
            this.rbtnCancelar.Location = new System.Drawing.Point(214, 303);
            this.rbtnCancelar.Name = "rbtnCancelar";
            this.rbtnCancelar.Size = new System.Drawing.Size(89, 43);
            this.rbtnCancelar.TabIndex = 21;
            this.rbtnCancelar.Text = "Cancelar";
            this.rbtnCancelar.TextColor = System.Drawing.Color.White;
            this.rbtnCancelar.UseVisualStyleBackColor = false;
            this.rbtnCancelar.Click += new System.EventHandler(this.rbtnCancelar_Click);
            // 
            // rbtnConfirmar
            // 
            this.rbtnConfirmar.BackColor = System.Drawing.Color.Green;
            this.rbtnConfirmar.BackgroundColor = System.Drawing.Color.Green;
            this.rbtnConfirmar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rbtnConfirmar.BorderRadius = 20;
            this.rbtnConfirmar.BorderSize = 0;
            this.rbtnConfirmar.FlatAppearance.BorderSize = 0;
            this.rbtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnConfirmar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnConfirmar.ForeColor = System.Drawing.Color.White;
            this.rbtnConfirmar.Location = new System.Drawing.Point(120, 303);
            this.rbtnConfirmar.Name = "rbtnConfirmar";
            this.rbtnConfirmar.Size = new System.Drawing.Size(88, 43);
            this.rbtnConfirmar.TabIndex = 20;
            this.rbtnConfirmar.Text = "Confirmar";
            this.rbtnConfirmar.TextColor = System.Drawing.Color.White;
            this.rbtnConfirmar.UseVisualStyleBackColor = false;
            // 
            // FrmNuevaTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Banco.Properties.Resources.login_background_2;
            this.ClientSize = new System.Drawing.Size(633, 439);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNuevaTransferencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Nueva Transferencia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConcepto;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.ComboBox cboOrigen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cboDestinatario;
        private System.Windows.Forms.Button btnAgregarDest;
        private System.Windows.Forms.Panel panel1;
        private Resources.RButton rbtnCancelar;
        private Resources.RButton rbtnConfirmar;
    }
}