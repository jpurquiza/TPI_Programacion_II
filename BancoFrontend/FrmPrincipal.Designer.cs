
namespace BancoFrontend
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlAltaProductosDD = new System.Windows.Forms.Panel();
            this.btnAltaPrestamo = new BancoFrontend.Resources.RButton();
            this.btnAltaProductos = new BancoFrontend.Resources.RButton();
            this.btnAltaCuenta = new BancoFrontend.Resources.RButton();
            this.btnAltaTC = new BancoFrontend.Resources.RButton();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.PanelTransaccionDropDown = new System.Windows.Forms.Panel();
            this.btnDestinatarios = new BancoFrontend.Resources.RButton();
            this.btnNvaTransferencia = new BancoFrontend.Resources.RButton();
            this.btnTransaccion = new BancoFrontend.Resources.RButton();
            this.btnReportes = new BancoFrontend.Resources.RButton();
            this.btnCerrarSesion = new BancoFrontend.Resources.RButton();
            this.rButton1 = new BancoFrontend.Resources.RButton();
            this.rbtnAcercaDe = new BancoFrontend.Resources.RButton();
            this.pContainer = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.pnlAltaProductosDD.SuspendLayout();
            this.PanelTransaccionDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(232, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 448);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlAltaProductosDD);
            this.panel2.Controls.Add(this.lblBienvenido);
            this.panel2.Controls.Add(this.PanelTransaccionDropDown);
            this.panel2.Controls.Add(this.btnReportes);
            this.panel2.Controls.Add(this.btnCerrarSesion);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.rButton1);
            this.panel2.Controls.Add(this.rbtnAcercaDe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 450);
            this.panel2.TabIndex = 14;
            // 
            // pnlAltaProductosDD
            // 
            this.pnlAltaProductosDD.Controls.Add(this.btnAltaProductos);
            this.pnlAltaProductosDD.Controls.Add(this.btnAltaPrestamo);
            this.pnlAltaProductosDD.Controls.Add(this.btnAltaCuenta);
            this.pnlAltaProductosDD.Controls.Add(this.btnAltaTC);
            this.pnlAltaProductosDD.Location = new System.Drawing.Point(14, 88);
            this.pnlAltaProductosDD.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAltaProductosDD.MaximumSize = new System.Drawing.Size(200, 232);
            this.pnlAltaProductosDD.MinimumSize = new System.Drawing.Size(200, 40);
            this.pnlAltaProductosDD.Name = "pnlAltaProductosDD";
            this.pnlAltaProductosDD.Size = new System.Drawing.Size(200, 40);
            this.pnlAltaProductosDD.TabIndex = 15;
            // 
            // btnAltaPrestamo
            // 
            this.btnAltaPrestamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(152)))));
            this.btnAltaPrestamo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(152)))));
            this.btnAltaPrestamo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAltaPrestamo.BorderRadius = 20;
            this.btnAltaPrestamo.BorderSize = 0;
            this.btnAltaPrestamo.FlatAppearance.BorderSize = 0;
            this.btnAltaPrestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaPrestamo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAltaPrestamo.ForeColor = System.Drawing.Color.White;
            this.btnAltaPrestamo.Location = new System.Drawing.Point(0, 192);
            this.btnAltaPrestamo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAltaPrestamo.Name = "btnAltaPrestamo";
            this.btnAltaPrestamo.Size = new System.Drawing.Size(200, 40);
            this.btnAltaPrestamo.TabIndex = 15;
            this.btnAltaPrestamo.Text = "Préstamos";
            this.btnAltaPrestamo.TextColor = System.Drawing.Color.White;
            this.btnAltaPrestamo.UseVisualStyleBackColor = false;
            this.btnAltaPrestamo.Click += new System.EventHandler(this.btnAltaPrestamo_Click);
            // 
            // btnAltaProductos
            // 
            this.btnAltaProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(152)))));
            this.btnAltaProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(152)))));
            this.btnAltaProductos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAltaProductos.BorderRadius = 20;
            this.btnAltaProductos.BorderSize = 0;
            this.btnAltaProductos.FlatAppearance.BorderSize = 0;
            this.btnAltaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaProductos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAltaProductos.ForeColor = System.Drawing.Color.White;
            this.btnAltaProductos.Image = global::BancoFrontend.Properties.Resources.amplia;
            this.btnAltaProductos.Location = new System.Drawing.Point(0, 0);
            this.btnAltaProductos.Name = "btnAltaProductos";
            this.btnAltaProductos.Size = new System.Drawing.Size(200, 40);
            this.btnAltaProductos.TabIndex = 11;
            this.btnAltaProductos.Text = "Alta de productos";
            this.btnAltaProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAltaProductos.TextColor = System.Drawing.Color.White;
            this.btnAltaProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAltaProductos.UseVisualStyleBackColor = false;
            this.btnAltaProductos.Click += new System.EventHandler(this.btnAltaProductos_Click);
            // 
            // btnAltaCuenta
            // 
            this.btnAltaCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(152)))));
            this.btnAltaCuenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(152)))));
            this.btnAltaCuenta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAltaCuenta.BorderRadius = 20;
            this.btnAltaCuenta.BorderSize = 0;
            this.btnAltaCuenta.FlatAppearance.BorderSize = 0;
            this.btnAltaCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaCuenta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAltaCuenta.ForeColor = System.Drawing.Color.White;
            this.btnAltaCuenta.Location = new System.Drawing.Point(0, 64);
            this.btnAltaCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.btnAltaCuenta.Name = "btnAltaCuenta";
            this.btnAltaCuenta.Size = new System.Drawing.Size(200, 40);
            this.btnAltaCuenta.TabIndex = 12;
            this.btnAltaCuenta.Text = "Cuentas";
            this.btnAltaCuenta.TextColor = System.Drawing.Color.White;
            this.btnAltaCuenta.UseVisualStyleBackColor = false;
            this.btnAltaCuenta.Click += new System.EventHandler(this.btnAltaCuenta_Click);
            // 
            // btnAltaTC
            // 
            this.btnAltaTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(152)))));
            this.btnAltaTC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(152)))));
            this.btnAltaTC.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAltaTC.BorderRadius = 20;
            this.btnAltaTC.BorderSize = 0;
            this.btnAltaTC.FlatAppearance.BorderSize = 0;
            this.btnAltaTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltaTC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAltaTC.ForeColor = System.Drawing.Color.White;
            this.btnAltaTC.Location = new System.Drawing.Point(0, 128);
            this.btnAltaTC.Margin = new System.Windows.Forms.Padding(4);
            this.btnAltaTC.Name = "btnAltaTC";
            this.btnAltaTC.Size = new System.Drawing.Size(200, 40);
            this.btnAltaTC.TabIndex = 14;
            this.btnAltaTC.Text = "Tarjetas de Crédito";
            this.btnAltaTC.TextColor = System.Drawing.Color.White;
            this.btnAltaTC.UseVisualStyleBackColor = false;
            this.btnAltaTC.Click += new System.EventHandler(this.btnAltaTC_Click);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenido.Location = new System.Drawing.Point(64, 16);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(100, 23);
            this.lblBienvenido.TabIndex = 16;
            this.lblBienvenido.Text = "Bienvenido";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelTransaccionDropDown
            // 
            this.PanelTransaccionDropDown.Controls.Add(this.btnDestinatarios);
            this.PanelTransaccionDropDown.Controls.Add(this.btnNvaTransferencia);
            this.PanelTransaccionDropDown.Controls.Add(this.btnTransaccion);
            this.PanelTransaccionDropDown.Location = new System.Drawing.Point(16, 152);
            this.PanelTransaccionDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.PanelTransaccionDropDown.MaximumSize = new System.Drawing.Size(200, 168);
            this.PanelTransaccionDropDown.MinimumSize = new System.Drawing.Size(200, 40);
            this.PanelTransaccionDropDown.Name = "PanelTransaccionDropDown";
            this.PanelTransaccionDropDown.Size = new System.Drawing.Size(200, 40);
            this.PanelTransaccionDropDown.TabIndex = 1;
            // 
            // btnDestinatarios
            // 
            this.btnDestinatarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(152)))));
            this.btnDestinatarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(152)))));
            this.btnDestinatarios.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDestinatarios.BorderRadius = 20;
            this.btnDestinatarios.BorderSize = 0;
            this.btnDestinatarios.FlatAppearance.BorderSize = 0;
            this.btnDestinatarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestinatarios.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDestinatarios.ForeColor = System.Drawing.Color.White;
            this.btnDestinatarios.Location = new System.Drawing.Point(0, 128);
            this.btnDestinatarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnDestinatarios.Name = "btnDestinatarios";
            this.btnDestinatarios.Size = new System.Drawing.Size(200, 40);
            this.btnDestinatarios.TabIndex = 13;
            this.btnDestinatarios.Text = "Destinatarios";
            this.btnDestinatarios.TextColor = System.Drawing.Color.White;
            this.btnDestinatarios.UseVisualStyleBackColor = false;
            this.btnDestinatarios.Click += new System.EventHandler(this.btnDestinatarios_Click);
            // 
            // btnNvaTransferencia
            // 
            this.btnNvaTransferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(152)))));
            this.btnNvaTransferencia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(152)))));
            this.btnNvaTransferencia.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNvaTransferencia.BorderRadius = 20;
            this.btnNvaTransferencia.BorderSize = 0;
            this.btnNvaTransferencia.FlatAppearance.BorderSize = 0;
            this.btnNvaTransferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNvaTransferencia.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNvaTransferencia.ForeColor = System.Drawing.Color.White;
            this.btnNvaTransferencia.Location = new System.Drawing.Point(0, 64);
            this.btnNvaTransferencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnNvaTransferencia.Name = "btnNvaTransferencia";
            this.btnNvaTransferencia.Size = new System.Drawing.Size(200, 40);
            this.btnNvaTransferencia.TabIndex = 12;
            this.btnNvaTransferencia.Text = "Nueva Transferencia";
            this.btnNvaTransferencia.TextColor = System.Drawing.Color.White;
            this.btnNvaTransferencia.UseVisualStyleBackColor = false;
            this.btnNvaTransferencia.Click += new System.EventHandler(this.btnNvaTransferencia_Click);
            // 
            // btnTransaccion
            // 
            this.btnTransaccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(152)))));
            this.btnTransaccion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(152)))));
            this.btnTransaccion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTransaccion.BorderRadius = 20;
            this.btnTransaccion.BorderSize = 0;
            this.btnTransaccion.FlatAppearance.BorderSize = 0;
            this.btnTransaccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransaccion.ForeColor = System.Drawing.Color.White;
            this.btnTransaccion.Image = global::BancoFrontend.Properties.Resources.amplia;
            this.btnTransaccion.Location = new System.Drawing.Point(0, 0);
            this.btnTransaccion.Name = "btnTransaccion";
            this.btnTransaccion.Size = new System.Drawing.Size(200, 40);
            this.btnTransaccion.TabIndex = 11;
            this.btnTransaccion.Text = "Transferencias";
            this.btnTransaccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTransaccion.TextColor = System.Drawing.Color.White;
            this.btnTransaccion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTransaccion.UseVisualStyleBackColor = false;
            this.btnTransaccion.Click += new System.EventHandler(this.btnTransaccion_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(152)))));
            this.btnReportes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(106)))), ((int)(((byte)(152)))));
            this.btnReportes.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReportes.BorderRadius = 20;
            this.btnReportes.BorderSize = 0;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Location = new System.Drawing.Point(16, 216);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(200, 40);
            this.btnReportes.TabIndex = 14;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextColor = System.Drawing.Color.White;
            this.btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnCerrarSesion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(55)))), ((int)(((byte)(60)))));
            this.btnCerrarSesion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCerrarSesion.BorderRadius = 20;
            this.btnCerrarSesion.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(16, 400);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(200, 40);
            this.btnCerrarSesion.TabIndex = 9;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextColor = System.Drawing.Color.White;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // rButton1
            // 
            this.rButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.rButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.rButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rButton1.BorderRadius = 0;
            this.rButton1.BorderSize = 0;
            this.rButton1.FlatAppearance.BorderSize = 0;
            this.rButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rButton1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rButton1.ForeColor = System.Drawing.Color.White;
            this.rButton1.Location = new System.Drawing.Point(-3, 490);
            this.rButton1.Margin = new System.Windows.Forms.Padding(4);
            this.rButton1.Name = "rButton1";
            this.rButton1.Size = new System.Drawing.Size(268, 51);
            this.rButton1.TabIndex = 13;
            this.rButton1.Text = "Soporte";
            this.rButton1.TextColor = System.Drawing.Color.White;
            this.rButton1.UseVisualStyleBackColor = false;
            // 
            // rbtnAcercaDe
            // 
            this.rbtnAcercaDe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.rbtnAcercaDe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.rbtnAcercaDe.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rbtnAcercaDe.BorderRadius = 0;
            this.rbtnAcercaDe.BorderSize = 0;
            this.rbtnAcercaDe.FlatAppearance.BorderSize = 0;
            this.rbtnAcercaDe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbtnAcercaDe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnAcercaDe.ForeColor = System.Drawing.Color.White;
            this.rbtnAcercaDe.Location = new System.Drawing.Point(-3, 574);
            this.rbtnAcercaDe.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnAcercaDe.Name = "rbtnAcercaDe";
            this.rbtnAcercaDe.Size = new System.Drawing.Size(268, 45);
            this.rbtnAcercaDe.TabIndex = 13;
            this.rbtnAcercaDe.Text = "Acerca De:";
            this.rbtnAcercaDe.TextColor = System.Drawing.Color.White;
            this.rbtnAcercaDe.UseVisualStyleBackColor = false;
            // 
            // pContainer
            // 
            this.pContainer.BackgroundImage = global::BancoFrontend.Properties.Resources.background;
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(230, 0);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(800, 450);
            this.pContainer.TabIndex = 15;
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1030, 450);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlAltaProductosDD.ResumeLayout(false);
            this.PanelTransaccionDropDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Resources.RButton btnCerrarSesion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Resources.RButton btnReportes;
        private Resources.RButton rButton1;
        private Resources.RButton rbtnAcercaDe;
        private System.Windows.Forms.Panel PanelTransaccionDropDown;
        private Resources.RButton btnDestinatarios;
        private Resources.RButton btnNvaTransferencia;
        private Resources.RButton btnTransaccion;
        internal System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Panel pnlAltaProductosDD;
        private Resources.RButton btnAltaPrestamo;
        private Resources.RButton btnAltaTC;
        private Resources.RButton btnAltaCuenta;
        private Resources.RButton btnAltaProductos;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblBienvenido;
    }
}