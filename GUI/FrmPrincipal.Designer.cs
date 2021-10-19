
namespace Banco.GUI
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
            this.PanelSeleccionPrincipal = new System.Windows.Forms.Panel();
            this.PanelTransaccionDropDown = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnOpc5 = new Banco.Resources.RButton();
            this.btnOpc4 = new Banco.Resources.RButton();
            this.btnOpc3 = new Banco.Resources.RButton();
            this.btnopc2 = new Banco.Resources.RButton();
            this.btnOpc1 = new Banco.Resources.RButton();
            this.btnTransaccion = new Banco.Resources.RButton();
            this.btnSoporte = new Banco.Resources.RButton();
            this.btnArchivo = new Banco.Resources.RButton();
            this.btnCerrarSesion = new Banco.Resources.RButton();
            this.rButton1 = new Banco.Resources.RButton();
            this.PanelSeleccionPrincipal.SuspendLayout();
            this.PanelTransaccionDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSeleccionPrincipal
            // 
            this.PanelSeleccionPrincipal.Controls.Add(this.rButton1);
            this.PanelSeleccionPrincipal.Controls.Add(this.btnSoporte);
            this.PanelSeleccionPrincipal.Controls.Add(this.btnArchivo);
            this.PanelSeleccionPrincipal.Controls.Add(this.btnCerrarSesion);
            this.PanelSeleccionPrincipal.Location = new System.Drawing.Point(12, 13);
            this.PanelSeleccionPrincipal.Name = "PanelSeleccionPrincipal";
            this.PanelSeleccionPrincipal.Size = new System.Drawing.Size(230, 443);
            this.PanelSeleccionPrincipal.TabIndex = 0;
            // 
            // PanelTransaccionDropDown
            // 
            this.PanelTransaccionDropDown.Controls.Add(this.btnOpc5);
            this.PanelTransaccionDropDown.Controls.Add(this.btnOpc4);
            this.PanelTransaccionDropDown.Controls.Add(this.btnOpc3);
            this.PanelTransaccionDropDown.Controls.Add(this.btnopc2);
            this.PanelTransaccionDropDown.Controls.Add(this.btnOpc1);
            this.PanelTransaccionDropDown.Controls.Add(this.btnTransaccion);
            this.PanelTransaccionDropDown.Location = new System.Drawing.Point(12, 139);
            this.PanelTransaccionDropDown.MaximumSize = new System.Drawing.Size(230, 235);
            this.PanelTransaccionDropDown.MinimumSize = new System.Drawing.Size(230, 55);
            this.PanelTransaccionDropDown.Name = "PanelTransaccionDropDown";
            this.PanelTransaccionDropDown.Size = new System.Drawing.Size(230, 55);
            this.PanelTransaccionDropDown.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnOpc5
            // 
            this.btnOpc5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOpc5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOpc5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOpc5.BorderRadius = 0;
            this.btnOpc5.BorderSize = 0;
            this.btnOpc5.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpc5.FlatAppearance.BorderSize = 0;
            this.btnOpc5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpc5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpc5.ForeColor = System.Drawing.Color.White;
            this.btnOpc5.Location = new System.Drawing.Point(0, 195);
            this.btnOpc5.Name = "btnOpc5";
            this.btnOpc5.Size = new System.Drawing.Size(230, 36);
            this.btnOpc5.TabIndex = 16;
            this.btnOpc5.Text = "Opción 5";
            this.btnOpc5.TextColor = System.Drawing.Color.White;
            this.btnOpc5.UseVisualStyleBackColor = false;
            // 
            // btnOpc4
            // 
            this.btnOpc4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOpc4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOpc4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOpc4.BorderRadius = 0;
            this.btnOpc4.BorderSize = 0;
            this.btnOpc4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpc4.FlatAppearance.BorderSize = 0;
            this.btnOpc4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpc4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpc4.ForeColor = System.Drawing.Color.White;
            this.btnOpc4.Location = new System.Drawing.Point(0, 160);
            this.btnOpc4.Name = "btnOpc4";
            this.btnOpc4.Size = new System.Drawing.Size(230, 35);
            this.btnOpc4.TabIndex = 15;
            this.btnOpc4.Text = "Opción4";
            this.btnOpc4.TextColor = System.Drawing.Color.White;
            this.btnOpc4.UseVisualStyleBackColor = false;
            // 
            // btnOpc3
            // 
            this.btnOpc3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOpc3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOpc3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOpc3.BorderRadius = 0;
            this.btnOpc3.BorderSize = 0;
            this.btnOpc3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpc3.FlatAppearance.BorderSize = 0;
            this.btnOpc3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpc3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpc3.ForeColor = System.Drawing.Color.White;
            this.btnOpc3.Location = new System.Drawing.Point(0, 125);
            this.btnOpc3.Name = "btnOpc3";
            this.btnOpc3.Size = new System.Drawing.Size(230, 35);
            this.btnOpc3.TabIndex = 14;
            this.btnOpc3.Text = "Opción 3";
            this.btnOpc3.TextColor = System.Drawing.Color.White;
            this.btnOpc3.UseVisualStyleBackColor = false;
            // 
            // btnopc2
            // 
            this.btnopc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnopc2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnopc2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnopc2.BorderRadius = 0;
            this.btnopc2.BorderSize = 0;
            this.btnopc2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnopc2.FlatAppearance.BorderSize = 0;
            this.btnopc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnopc2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnopc2.ForeColor = System.Drawing.Color.White;
            this.btnopc2.Location = new System.Drawing.Point(0, 90);
            this.btnopc2.Name = "btnopc2";
            this.btnopc2.Size = new System.Drawing.Size(230, 35);
            this.btnopc2.TabIndex = 13;
            this.btnopc2.Text = "Opción 2";
            this.btnopc2.TextColor = System.Drawing.Color.White;
            this.btnopc2.UseVisualStyleBackColor = false;
            // 
            // btnOpc1
            // 
            this.btnOpc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOpc1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnOpc1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOpc1.BorderRadius = 0;
            this.btnOpc1.BorderSize = 0;
            this.btnOpc1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpc1.FlatAppearance.BorderSize = 0;
            this.btnOpc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpc1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpc1.ForeColor = System.Drawing.Color.White;
            this.btnOpc1.Location = new System.Drawing.Point(0, 55);
            this.btnOpc1.Name = "btnOpc1";
            this.btnOpc1.Size = new System.Drawing.Size(230, 35);
            this.btnOpc1.TabIndex = 12;
            this.btnOpc1.Text = "Opción 1";
            this.btnOpc1.TextColor = System.Drawing.Color.White;
            this.btnOpc1.UseVisualStyleBackColor = false;
            // 
            // btnTransaccion
            // 
            this.btnTransaccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.btnTransaccion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.btnTransaccion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTransaccion.BorderRadius = 0;
            this.btnTransaccion.BorderSize = 0;
            this.btnTransaccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransaccion.FlatAppearance.BorderSize = 0;
            this.btnTransaccion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTransaccion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaccion.ForeColor = System.Drawing.Color.White;
            this.btnTransaccion.Image = global::Banco.Properties.Resources.amplia3;
            this.btnTransaccion.Location = new System.Drawing.Point(0, 0);
            this.btnTransaccion.Name = "btnTransaccion";
            this.btnTransaccion.Size = new System.Drawing.Size(230, 55);
            this.btnTransaccion.TabIndex = 11;
            this.btnTransaccion.Text = "Transacción";
            this.btnTransaccion.TextColor = System.Drawing.Color.White;
            this.btnTransaccion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnTransaccion.UseVisualStyleBackColor = false;
            this.btnTransaccion.Click += new System.EventHandler(this.btnTransaccion_Click);
            // 
            // btnSoporte
            // 
            this.btnSoporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.btnSoporte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.btnSoporte.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSoporte.BorderRadius = 0;
            this.btnSoporte.BorderSize = 0;
            this.btnSoporte.FlatAppearance.BorderSize = 0;
            this.btnSoporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSoporte.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoporte.ForeColor = System.Drawing.Color.White;
            this.btnSoporte.Location = new System.Drawing.Point(-1, 69);
            this.btnSoporte.Name = "btnSoporte";
            this.btnSoporte.Size = new System.Drawing.Size(230, 51);
            this.btnSoporte.TabIndex = 11;
            this.btnSoporte.Text = "Soporte";
            this.btnSoporte.TextColor = System.Drawing.Color.White;
            this.btnSoporte.UseVisualStyleBackColor = false;
            // 
            // btnArchivo
            // 
            this.btnArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.btnArchivo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.btnArchivo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnArchivo.BorderRadius = 0;
            this.btnArchivo.BorderSize = 0;
            this.btnArchivo.FlatAppearance.BorderSize = 0;
            this.btnArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArchivo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchivo.ForeColor = System.Drawing.Color.White;
            this.btnArchivo.Location = new System.Drawing.Point(0, 12);
            this.btnArchivo.Name = "btnArchivo";
            this.btnArchivo.Size = new System.Drawing.Size(230, 51);
            this.btnArchivo.TabIndex = 10;
            this.btnArchivo.Text = "Archivo";
            this.btnArchivo.TextColor = System.Drawing.Color.White;
            this.btnArchivo.UseVisualStyleBackColor = false;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.btnCerrarSesion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.btnCerrarSesion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCerrarSesion.BorderRadius = 20;
            this.btnCerrarSesion.BorderSize = 0;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(31, 388);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(153, 43);
            this.btnCerrarSesion.TabIndex = 9;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.TextColor = System.Drawing.Color.White;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
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
            this.rButton1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButton1.ForeColor = System.Drawing.Color.White;
            this.rButton1.Location = new System.Drawing.Point(0, 196);
            this.rButton1.Name = "rButton1";
            this.rButton1.Size = new System.Drawing.Size(230, 51);
            this.rButton1.TabIndex = 12;
            this.rButton1.Text = "Soporte";
            this.rButton1.TextColor = System.Drawing.Color.White;
            this.rButton1.UseVisualStyleBackColor = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 460);
            this.Controls.Add(this.PanelTransaccionDropDown);
            this.Controls.Add(this.PanelSeleccionPrincipal);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.PanelSeleccionPrincipal.ResumeLayout(false);
            this.PanelTransaccionDropDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelSeleccionPrincipal;
        private System.Windows.Forms.Panel PanelTransaccionDropDown;
        private Resources.RButton btnCerrarSesion;
        private Resources.RButton btnArchivo;
        private Resources.RButton btnOpc5;
        private Resources.RButton btnOpc4;
        private Resources.RButton btnOpc3;
        private Resources.RButton btnopc2;
        private Resources.RButton btnOpc1;
        private Resources.RButton btnTransaccion;
        private Resources.RButton btnSoporte;
        private System.Windows.Forms.Timer timer1;
        private Resources.RButton rButton1;
    }
}