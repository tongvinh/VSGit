using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BUS;
using System.Collections.Generic;
using DAL;

namespace DocumentManage
{
    public partial class XtraReportExport : DevExpress.XtraReports.UI.XtraReport
    {
        ReportBUS re = new ReportBUS();
        int IDDocument;
        public XtraReportExport()
        {
            InitializeComponent();
        }
        public XtraReportExport(int IDDocument)
        {
            InitializeComponent();
            this.IDDocument = IDDocument;
            objectDataSource1.DataSource = re.getInfoExport(IDDocument);
            objectDataSource2.DataSource = re.getDetailExports(IDDocument);
            pDoiSoThanhChu.Value = re.TienBangChuExport(IDDocument);
            pDoiSoThanhChu.Visible = false;
        }

        private void reportHeaderBand1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }
    }
}
