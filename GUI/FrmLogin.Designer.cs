
namespace Banco
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbLogin = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gpbLogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbLogin
            // 
            this.gpbLogin.Controls.Add(this.btnRegistrar);
            this.gpbLogin.Controls.Add(this.btnIngresar);
            this.gpbLogin.Controls.Add(this.txtDni);
            this.gpbLogin.Controls.Add(this.lblDni);
            this.gpbLogin.Controls.Add(this.txtClave);
            this.gpbLogin.Controls.Add(this.lblClave);
            this.gpbLogin.Location = new System.Drawing.Point(230, 15);
            this.gpbLogin.Name = "gpbLogin";
            this.gpbLogin.Size = new System.Drawing.Size(216, 230);
            this.gpbLogin.TabIndex = 7;
            this.gpbLogin.TabStop = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(60, 170);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(113, 23);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "No estoy registrado";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(60, 124);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(113, 23);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(60, 30);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(127, 20);
            this.txtDni.TabIndex = 4;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(2, 28);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(45, 20);
            this.lblDni.TabIndex = 2;
            this.lblDni.Text = "DNI:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(60, 69);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(127, 20);
            this.txtClave.TabIndex = 5;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(-4, 69);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(58, 20);
            this.lblClave.TabIndex = 3;
            this.lblClave.Text = "Clave:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gpbLogin);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 258);
            this.panel1.TabIndex = 6;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 293);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLogin";
            this.Text = "Ingreso";
            this.gpbLogin.ResumeLayout(false);
            this.gpbLogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbLogin;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Panel panel1;
    }
}

