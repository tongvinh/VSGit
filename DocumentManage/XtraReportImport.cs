using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BUS;

namespace DocumentManage
{
    public partial class XtraReportImport : DevExpress.XtraReports.UI.XtraReport
    {
        ReportBUS re = new ReportBUS();
        int IDDocument;
        public XtraReportImport()
        {
            InitializeComponent();
        }
        public XtraReportImport(int IDDocument)
        {
            InitializeComponent();
            this.IDDocument = IDDocument;
            objectDataSource1.DataSource = re.getInfo(IDDocument);
            objectDataSource2.DataSource = re.getDetails(IDDocument);
        }
    }
}
