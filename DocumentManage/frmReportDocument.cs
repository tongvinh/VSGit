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
using Microsoft.Reporting.WinForms;

namespace DocumentManage
{
    public partial class frmReportDocument : Form
    {
        ReportBUS re = new ReportBUS();
        int IDDocument;
        public frmReportDocument()
        {
            InitializeComponent();
        }
        public frmReportDocument(int IDDocument)
        {
            InitializeComponent();
            this.IDDocument = IDDocument;
        }
        private void frmReportDocument_Load(object sender, EventArgs e)
        {
            DetailDocumentBindingSource.DataSource = re.getDetails(IDDocument);
            InforDocumentBindingSource.DataSource = re.getInfo(IDDocument);
            //Insert image
            this.reportViewer1.RefreshReport();
        }
    }
}
