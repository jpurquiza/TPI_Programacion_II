
namespace BancoFrontend
{
    partial class FrmAltaCuenta
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
            this.rbtnCancelar = new BancoFrontend.Resources.RButton();
            this.rbtnConfirmar = new BancoFrontend.Resources.RButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoCuentas = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnCancelar);
            this.panel1.Controls.Add(this.rbtnConfirmar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboTipoCuentas);
            this.panel1.Location = new System.Drawing.Point(192, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 360);
            this.panel1.TabIndex = 0;
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
            this.rbtnCancelar.Location = new System.Drawing.Point(208, 296);
            this.rbtnCancelar.Name = "rbtnCancelar";
            this.rbtnCancelar.Size = new System.Drawing.Size(168, 38);
            this.rbtnCancelar.TabIndex = 10;
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
            this.rbtnConfirmar.Location = new System.Drawing.Point(16, 296);
            this.rbtnConfirmar.Name = "rbtnConfirmar";
            this.rbtnConfirmar.Size = new System.Drawing.Size(168, 38);
            this.rbtnConfirmar.TabIndex = 9;
            this.rbtnConfirmar.Text = "Confirmar";
            this.rbtnConfirmar.TextColor = System.Drawing.Color.White;
            this.rbtnConfirmar.UseVisualStyleBackColor = false;
            this.rbtnConfirmar.Click += new System.EventHandler(this.rbtnConfirmar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Luego solo tenés que Confirmar la operación.\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "¡Ahora podés dar de alta tu cuenta vos mismo!\r\n¡Es mucho más fácil!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "En el siguiente desplegable por favor selcciona \r\nel tipo de cuenta que querés da" +
    "r de alta.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboTipoCuentas
            // 
            this.cboTipoCuentas.FormattingEnabled = true;
            this.cboTipoCuentas.Location = new System.Drawing.Point(96, 224);
            this.cboTipoCuentas.Name = "cboTipoCuentas";
            this.cboTipoCuentas.Size = new System.Drawing.Size(216, 27);
            this.cboTipoCuentas.TabIndex = 0;
            // 
            // FrmAltaCuenta
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::BancoFrontend.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAltaCuenta";
            this.Text = "FrmAltaCuenta";
            this.Load += new System.EventHandler(this.FrmAltaCuenta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoCuentas;
        private Resources.RButton rbtnCancelar;
        private Resources.RButton rbtnConfirmar;
    }
}