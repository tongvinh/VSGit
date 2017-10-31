namespace DocumentManage
{
    partial class frmReportDocument
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
            this.DetailDocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InforDocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DetailDocumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InforDocumentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Detail";
            reportDataSource1.Value = this.DetailDocumentBindingSource;
            reportDataSource2.Name = "Information";
            reportDataSource2.Value = this.InforDocumentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DocumentManage.ReportDocument.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1273, 567);
            this.reportViewer1.TabIndex = 0;
            // 
            // DetailDocumentBindingSource
            // 
            this.DetailDocumentBindingSource.DataSource = typeof(DAL.DetailDocument);
            // 
            // InforDocumentBindingSource
            // 
            this.InforDocumentBindingSource.DataSource = typeof(DAL.InforDocument);
            // 
            // frmReportDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 567);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportDocument";
            this.Text = "frmReportDocument";
            this.Load += new System.EventHandler(this.frmReportDocument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetailDocumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InforDocumentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DetailDocumentBindingSource;
        private System.Windows.Forms.BindingSource InforDocumentBindingSource;
    }
}