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

namespace DocumentManage
{
    public partial class frmReportDocumentExport : Form
    {
        int IDDocument;
        ReportBUS re = new ReportBUS();
        public frmReportDocumentExport()
        {
            InitializeComponent();
        }
        public frmReportDocumentExport(int IDDocument)
        {
            InitializeComponent();
            this.IDDocument = IDDocument;
        }
        private void frmReportDocumentExport_Load(object sender, EventArgs e)
        {
            DetailDocumentExportBindingSource.DataSource = re.getDetailExports(IDDocument);
            InforDocumentExportBindingSource.DataSource = re.getInfoExport(IDDocument);
            this.reportViewer1.RefreshReport();
        }
    }
}
