
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rTextBox2 = new Banco.Resources.RTextBox();
            this.rTextBox1 = new Banco.Resources.RTextBox();
            this.lklblRegistro = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngresar = new Banco.Resources.RButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Banco.Properties.Resources.login_background_21;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 500);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rTextBox2);
            this.panel2.Controls.Add(this.rTextBox1);
            this.panel2.Controls.Add(this.lklblRegistro);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnIngresar);
            this.panel2.Location = new System.Drawing.Point(487, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 464);
            this.panel2.TabIndex = 10;
            // 
            // rTextBox2
            // 
            this.rTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.rTextBox2.BorderColor = System.Drawing.Color.DimGray;
            this.rTextBox2.BorderFocusColor = System.Drawing.Color.Black;
            this.rTextBox2.BorderRadius = 0;
            this.rTextBox2.BorderSize = 1;
            this.rTextBox2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.rTextBox2.Location = new System.Drawing.Point(48, 155);
            this.rTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rTextBox2.Multiline = false;
            this.rTextBox2.Name = "rTextBox2";
            this.rTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.rTextBox2.PasswordChar = true;
            this.rTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rTextBox2.PlaceholderText = "Clave";
            this.rTextBox2.Size = new System.Drawing.Size(198, 34);
            this.rTextBox2.TabIndex = 14;
            this.rTextBox2.Texts = "";
            this.rTextBox2.UnderlinedStyle = true;
            // 
            // rTextBox1
            // 
            this.rTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.rTextBox1.BorderColor = System.Drawing.Color.DimGray;
            this.rTextBox1.BorderFocusColor = System.Drawing.Color.Black;
            this.rTextBox1.BorderRadius = 0;
            this.rTextBox1.BorderSize = 1;
            this.rTextBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rTextBox1.Location = new System.Drawing.Point(48, 101);
            this.rTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rTextBox1.Multiline = false;
            this.rTextBox1.Name = "rTextBox1";
            this.rTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.rTextBox1.PasswordChar = false;
            this.rTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rTextBox1.PlaceholderText = "DNI";
            this.rTextBox1.Size = new System.Drawing.Size(198, 34);
            this.rTextBox1.TabIndex = 13;
            this.rTextBox1.Texts = "";
            this.rTextBox1.UnderlinedStyle = true;
            // 
            // lklblRegistro
            // 
            this.lklblRegistro.ActiveLinkColor = System.Drawing.Color.Black;
            this.lklblRegistro.AutoSize = true;
            this.lklblRegistro.Font = new System.Drawing.Font("Calibri", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklblRegistro.LinkArea = new System.Windows.Forms.LinkArea(0, 19);
            this.lklblRegistro.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lklblRegistro.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(152)))));
            this.lklblRegistro.Location = new System.Drawing.Point(61, 377);
            this.lklblRegistro.Name = "lklblRegistro";
            this.lklblRegistro.Size = new System.Drawing.Size(181, 26);
            this.lklblRegistro.TabIndex = 12;
            this.lklblRegistro.TabStop = true;
            this.lklblRegistro.Text = "No estoy registrado";
            this.lklblRegistro.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ingresar a MiCuenta";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.btnIngresar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.btnIngresar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnIngresar.BorderRadius = 20;
            this.btnIngresar.BorderSize = 0;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(72, 207);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(153, 43);
            this.btnIngresar.TabIndex = 8;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.TextColor = System.Drawing.Color.White;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso MiCuenta";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Resources.RButton btnIngresar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lklblRegistro;
        private Resources.RTextBox rTextBox1;
        private Resources.RTextBox rTextBox2;
        private System.Windows.Forms.Panel panel1;
    }
}

