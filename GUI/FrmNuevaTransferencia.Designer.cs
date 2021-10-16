
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboDestinatario = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCbu = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblCbu = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApelldio = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(274, 64);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(66, 13);
            this.lblDestinatario.TabIndex = 0;
            this.lblDestinatario.Text = "Destinatario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Importe:";
            // 
            // lblConcepto
            // 
            this.lblConcepto.AutoSize = true;
            this.lblConcepto.Location = new System.Drawing.Point(30, 108);
            this.lblConcepto.Name = "lblConcepto";
            this.lblConcepto.Size = new System.Drawing.Size(53, 13);
            this.lblConcepto.TabIndex = 4;
            this.lblConcepto.Text = "Concepto";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(114, 64);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(121, 20);
            this.txtImporte.TabIndex = 5;
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(114, 101);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(121, 20);
            this.txtConcepto.TabIndex = 7;
            // 
            // cboOrigen
            // 
            this.cboOrigen.FormattingEnabled = true;
            this.cboOrigen.Location = new System.Drawing.Point(367, 18);
            this.cboOrigen.Name = "cboOrigen";
            this.cboOrigen.Size = new System.Drawing.Size(121, 21);
            this.cboOrigen.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Cuenta Origen:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(494, 21);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(95, 13);
            this.lblSaldo.TabIndex = 13;
            this.lblSaldo.Text = "Saldo Disponible $";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(35, 21);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(208, 364);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(167, 23);
            this.btnConfirmar.TabIndex = 15;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(546, 364);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cboDestinatario
            // 
            this.cboDestinatario.FormattingEnabled = true;
            this.cboDestinatario.Location = new System.Drawing.Point(367, 64);
            this.cboDestinatario.Name = "cboDestinatario";
            this.cboDestinatario.Size = new System.Drawing.Size(121, 21);
            this.cboDestinatario.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.lblDni);
            this.groupBox1.Controls.Add(this.lblApelldio);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblCbu);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtCbu);
            this.groupBox1.Location = new System.Drawing.Point(300, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 198);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Destino";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Agregar Destinatario";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtCbu
            // 
            this.txtCbu.Location = new System.Drawing.Point(135, 49);
            this.txtCbu.Name = "txtCbu";
            this.txtCbu.Size = new System.Drawing.Size(100, 20);
            this.txtCbu.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(135, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(135, 103);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // lblCbu
            // 
            this.lblCbu.AutoSize = true;
            this.lblCbu.Location = new System.Drawing.Point(23, 52);
            this.lblCbu.Name = "lblCbu";
            this.lblCbu.Size = new System.Drawing.Size(29, 13);
            this.lblCbu.TabIndex = 3;
            this.lblCbu.Text = "CBU";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 76);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApelldio
            // 
            this.lblApelldio.AutoSize = true;
            this.lblApelldio.Location = new System.Drawing.Point(17, 106);
            this.lblApelldio.Name = "lblApelldio";
            this.lblApelldio.Size = new System.Drawing.Size(44, 13);
            this.lblApelldio.TabIndex = 5;
            this.lblApelldio.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(17, 138);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 6;
            this.lblDni.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(135, 138);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 7;
            // 
            // FrmNuevaTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboDestinatario);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDestinatario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.cboOrigen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.lblConcepto);
            this.Controls.Add(this.label2);
            this.Name = "FrmNuevaTransferencia";
            this.Text = " Nueva Transferencia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboDestinatario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApelldio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCbu;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCbu;
        private System.Windows.Forms.Button button1;
    }
}