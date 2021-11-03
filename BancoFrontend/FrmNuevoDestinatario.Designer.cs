
namespace BancoFrontend
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
            this.dgvDestinatarios = new System.Windows.Forms.DataGridView();
            this.nombreDestinatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDestinatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDestinatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDestinatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbuDestintario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinatarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDestinatarios
            // 
            this.dgvDestinatarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestinatarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDestinatario,
            this.apellidoDestinatario,
            this.dniDestinatario,
            this.emailDestinatario,
            this.cbuDestintario});
            this.dgvDestinatarios.Location = new System.Drawing.Point(16, 24);
            this.dgvDestinatarios.Name = "dgvDestinatarios";
            this.dgvDestinatarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDestinatarios.RowTemplate.Height = 25;
            this.dgvDestinatarios.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvDestinatarios.Size = new System.Drawing.Size(664, 400);
            this.dgvDestinatarios.TabIndex = 0;
            this.dgvDestinatarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDestinatarios_CellContentClick);
            // 
            // nombreDestinatario
            // 
            this.nombreDestinatario.HeaderText = "Nombre";
            this.nombreDestinatario.Name = "nombreDestinatario";
            this.nombreDestinatario.ReadOnly = true;
            // 
            // apellidoDestinatario
            // 
            this.apellidoDestinatario.HeaderText = "Apellido";
            this.apellidoDestinatario.Name = "apellidoDestinatario";
            this.apellidoDestinatario.ReadOnly = true;
            // 
            // dniDestinatario
            // 
            this.dniDestinatario.HeaderText = "DNI";
            this.dniDestinatario.Name = "dniDestinatario";
            this.dniDestinatario.ReadOnly = true;
            // 
            // emailDestinatario
            // 
            this.emailDestinatario.HeaderText = "Email";
            this.emailDestinatario.Name = "emailDestinatario";
            this.emailDestinatario.ReadOnly = true;
            // 
            // cbuDestintario
            // 
            this.cbuDestintario.HeaderText = "CBU";
            this.cbuDestintario.Name = "cbuDestintario";
            this.cbuDestintario.ReadOnly = true;
            // 
            // FrmNuevoDestinatario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BancoFrontend.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.dgvDestinatarios);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmNuevoDestinatario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNuevoDestinatario";
            this.Load += new System.EventHandler(this.FrmNuevoDestinatario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinatarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDestinatarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDestinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDestinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDestinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDestinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbuDestintario;
    }
}