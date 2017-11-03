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
        public frmXtraReportImport()
        {
            InitializeComponent();
        }
        public frmXtraReportImport(int IDDocument)
        {
            InitializeComponent();
            this.IDDocument = IDDocument;
        }

        private void frmXtraReportImport_Load(object sender, EventArgs e)
        {
            XtraReportImport report = new XtraReportImport(IDDocument);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }
    }
}
