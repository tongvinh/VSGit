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
            this.InforDocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DetailDocumentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.InforDocumentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailDocumentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Imformation";
            reportDataSource1.Value = this.InforDocumentBindingSource;
            reportDataSource2.Name = "Detail";
            reportDataSource2.Value = this.DetailDocumentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DocumentManage.ReportDocument.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1273, 567);
            this.reportViewer1.TabIndex = 0;
            // 
            // InforDocumentBindingSource
            // 
            this.InforDocumentBindingSource.DataMember = "InforDocument";
            // 
            // DetailDocumentBindingSource
            // 
            this.DetailDocumentBindingSource.DataMember = "DetailDocument";
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
            ((System.ComponentModel.ISupportInitialize)(this.InforDocumentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetailDocumentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InforDocumentBindingSource;
        private System.Windows.Forms.BindingSource DetailDocumentBindingSource;
    }
}