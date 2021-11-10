
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
            this.cbuDestintario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDestinatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rbtnCancelar = new BancoFrontend.Resources.RButton();
            this.rbtnAgregar = new BancoFrontend.Resources.RButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestinatarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDestinatarios
            // 
            this.dgvDestinatarios.AllowUserToAddRows = false;
            this.dgvDestinatarios.AllowUserToDeleteRows = false;
            this.dgvDestinatarios.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvDestinatarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestinatarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDestinatario,
            this.apellidoDestinatario,
            this.dniDestinatario,
            this.cbuDestintario,
            this.emailDestinatario,
            this.Acciones,
            this.Eliminar});
            this.dgvDestinatarios.Location = new System.Drawing.Point(4, 24);
            this.dgvDestinatarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvDestinatarios.Name = "dgvDestinatarios";
            this.dgvDestinatarios.ReadOnly = true;
            this.dgvDestinatarios.RowTemplate.Height = 25;
            this.dgvDestinatarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDestinatarios.Size = new System.Drawing.Size(683, 360);
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
            // cbuDestintario
            // 
            this.cbuDestintario.HeaderText = "CBU";
            this.cbuDestintario.Name = "cbuDestintario";
            this.cbuDestintario.ReadOnly = true;
            // 
            // emailDestinatario
            // 
            this.emailDestinatario.HeaderText = "Email";
            this.emailDestinatario.Name = "emailDestinatario";
            this.emailDestinatario.ReadOnly = true;
            // 
            // Acciones
            // 
            this.Acciones.HeaderText = "Editar";
            this.Acciones.Name = "Acciones";
            this.Acciones.ReadOnly = true;
            this.Acciones.Text = "editar";
            this.Acciones.ToolTipText = "1";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // rbtnCancelar
            // 
            this.rbtnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.rbtnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.rbtnCancelar.BorderColor = System.Drawing.Color.Transparent;
            this.rbtnCancelar.BorderRadius = 15;
            this.rbtnCancelar.BorderSize = 0;
            this.rbtnCancelar.CausesValidation = false;
            this.rbtnCancelar.FlatAppearance.BorderSize = 0;
            this.rbtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnCancelar.ForeColor = System.Drawing.Color.White;
            this.rbtnCancelar.Location = new System.Drawing.Point(512, 400);
            this.rbtnCancelar.Name = "rbtnCancelar";
            this.rbtnCancelar.Size = new System.Drawing.Size(168, 38);
            this.rbtnCancelar.TabIndex = 10;
            this.rbtnCancelar.Text = "Cancelar";
            this.rbtnCancelar.TextColor = System.Drawing.Color.White;
            this.rbtnCancelar.UseVisualStyleBackColor = false;
            this.rbtnCancelar.Click += new System.EventHandler(this.rbtnCancelar_Click_1);
            // 
            // rbtnAgregar
            // 
            this.rbtnAgregar.BackColor = System.Drawing.Color.RoyalBlue;
            this.rbtnAgregar.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rbtnAgregar.BorderColor = System.Drawing.Color.Transparent;
            this.rbtnAgregar.BorderRadius = 15;
            this.rbtnAgregar.BorderSize = 0;
            this.rbtnAgregar.CausesValidation = false;
            this.rbtnAgregar.FlatAppearance.BorderSize = 0;
            this.rbtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnAgregar.ForeColor = System.Drawing.Color.White;
            this.rbtnAgregar.Location = new System.Drawing.Point(326, 400);
            this.rbtnAgregar.Name = "rbtnAgregar";
            this.rbtnAgregar.Size = new System.Drawing.Size(168, 38);
            this.rbtnAgregar.TabIndex = 11;
            this.rbtnAgregar.Text = "Nuevo";
            this.rbtnAgregar.TextColor = System.Drawing.Color.White;
            this.rbtnAgregar.UseVisualStyleBackColor = false;
            this.rbtnAgregar.Click += new System.EventHandler(this.rbtnAgregar_Click);
            // 
            // FrmNuevoDestinatario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BancoFrontend.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.rbtnAgregar);
            this.Controls.Add(this.rbtnCancelar);
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
        private Resources.RButton rbtnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDestinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDestinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDestinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cbuDestintario;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDestinatario;
        private System.Windows.Forms.DataGridViewButtonColumn Acciones;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private Resources.RButton rbtnAgregar;
    }
}