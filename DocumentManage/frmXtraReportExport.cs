using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DevExpress.XtraReports.UI;

namespace DocumentManage
{
    public partial class frmXtraReportExport : Form
    {
        ReportBUS re = new ReportBUS();
        int IDDocument;
        public frmXtraReportExport()
        {
            InitializeComponent();
        }
        public frmXtraReportExport(int IDDocument)
        {
            InitializeComponent();
            this.IDDocument = IDDocument;
        }

        private void frmXtraReportExport_Load(object sender, EventArgs e)
        {
            XtraReportExport report = new XtraReportExport(IDDocument);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
    }
}
