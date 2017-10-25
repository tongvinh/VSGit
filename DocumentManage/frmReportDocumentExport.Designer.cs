namespace DocumentManage
{
    partial class frmReportDocumentExport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.InforDocumentExportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DetailDocumentExportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.InforDocumentExportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailDocumentExportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Information";
            reportDataSource1.Value = this.InforDocumentExportBindingSource;
            reportDataSource2.Name = "Detail";
            reportDataSource2.Value = this.DetailDocumentExportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DocumentManage.ReportDocumentExport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1273, 537);
            this.reportViewer1.TabIndex = 0;
            // 
            // InforDocumentExportBindingSource
            // 
            this.InforDocumentExportBindingSource.DataSource = typeof(DAL.InforDocumentExport);
            // 
            // DetailDocumentExportBindingSource
            // 
            this.DetailDocumentExportBindingSource.DataSource = typeof(DAL.DetailDocumentExport);
            // 
            // frmReportDocumentExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 537);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportDocumentExport";
            this.Text = "frmReportDocumentExport";
            this.Load += new System.EventHandler(this.frmReportDocumentExport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InforDocumentExportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailDocumentExportBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InforDocumentExportBindingSource;
        private System.Windows.Forms.BindingSource DetailDocumentExportBindingSource;
    }
}