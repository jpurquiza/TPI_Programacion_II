
namespace BancoReporte
{
    partial class rptform
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BDpruebaDS = new BancoReporte.BDpruebaDS();
            this.SP_CONSLULTAR_TRANSACCIONESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SP_CONSLULTAR_TRANSACCIONESTableAdapter = new BancoReporte.BDpruebaDSTableAdapters.SP_CONSLULTAR_TRANSACCIONESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BDpruebaDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_CONSLULTAR_TRANSACCIONESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SP_CONSLULTAR_TRANSACCIONESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BancoReporte.Reporte2rdlc.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(574, 302);
            this.reportViewer1.TabIndex = 0;
            // 
            // BDpruebaDS
            // 
            this.BDpruebaDS.DataSetName = "BDpruebaDS";
            this.BDpruebaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SP_CONSLULTAR_TRANSACCIONESBindingSource
            // 
            this.SP_CONSLULTAR_TRANSACCIONESBindingSource.DataMember = "SP_CONSLULTAR_TRANSACCIONES";
            this.SP_CONSLULTAR_TRANSACCIONESBindingSource.DataSource = this.BDpruebaDS;
            // 
            // SP_CONSLULTAR_TRANSACCIONESTableAdapter
            // 
            this.SP_CONSLULTAR_TRANSACCIONESTableAdapter.ClearBeforeFill = true;
            // 
            // rptform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 302);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptform";
            this.Text = "rptform";
            this.Load += new System.EventHandler(this.rptform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BDpruebaDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SP_CONSLULTAR_TRANSACCIONESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BDpruebaDS BDpruebaDS;
        private System.Windows.Forms.BindingSource SP_CONSLULTAR_TRANSACCIONESBindingSource;
        private BDpruebaDSTableAdapters.SP_CONSLULTAR_TRANSACCIONESTableAdapter SP_CONSLULTAR_TRANSACCIONESTableAdapter;
    }
}