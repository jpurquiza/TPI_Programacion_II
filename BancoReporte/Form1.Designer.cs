
namespace BancoReporte
{
    partial class frmMovimientos
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dsMovimientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsMovimientos = new BancoReporte.dsMovimientos();
            this.rvMovimientos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsMovimientosTableAdapter = new BancoReporte.dsMovimientosTableAdapters.dsMovimientosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsMovimientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // dsMovimientosBindingSource
            // 
            this.dsMovimientosBindingSource.DataMember = "dsMovimientos";
            this.dsMovimientosBindingSource.DataSource = this.dsMovimientos;
            this.dsMovimientosBindingSource.CurrentChanged += new System.EventHandler(this.dsMovimientosBindingSource_CurrentChanged);
            // 
            // dsMovimientos
            // 
            this.dsMovimientos.DataSetName = "dsMovimientos";
            this.dsMovimientos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvMovimientos
            // 
            this.rvMovimientos.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dsMovimientosBindingSource;
            this.rvMovimientos.LocalReport.DataSources.Add(reportDataSource1);
            this.rvMovimientos.LocalReport.ReportEmbeddedResource = "BancoReporte.rptMovimientos.rdlc";
            this.rvMovimientos.Location = new System.Drawing.Point(0, 0);
            this.rvMovimientos.Name = "rvMovimientos";
            this.rvMovimientos.ServerReport.BearerToken = null;
            this.rvMovimientos.Size = new System.Drawing.Size(617, 450);
            this.rvMovimientos.TabIndex = 0;
            // 
            // dsMovimientosTableAdapter
            // 
            this.dsMovimientosTableAdapter.ClearBeforeFill = true;
            // 
            // frmMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 450);
            this.Controls.Add(this.rvMovimientos);
            this.Name = "frmMovimientos";
            this.Text = "Movimientos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsMovimientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsMovimientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvMovimientos;
        private dsMovimientos dsMovimientos;
        private System.Windows.Forms.BindingSource dsMovimientosBindingSource;
        private dsMovimientosTableAdapters.dsMovimientosTableAdapter dsMovimientosTableAdapter;
    }
}

