using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentManage
{
    public partial class frmXtraReportImport : Form
    {
        int IDDocument;
        string ToStore;
        public frmXtraReportImport()
        {
            InitializeComponent();
        }
        public frmXtraReportImport(int IDDocument,string ToStore)
        {
            InitializeComponent();
            this.IDDocument = IDDocument;
            this.ToStore = ToStore;
        }

        private void frmXtraReportImport_Load(object sender, EventArgs e)
        {
            XtraReportImport report = new XtraReportImport(IDDocument,ToStore);
            //foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
            //{
            //    p.Visible = false;
            //}
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
    }
}
