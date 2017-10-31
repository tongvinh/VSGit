using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentManage
{
    public partial class frmTestImagecs : Form
    {
       // string _imageUrl;
        string test = "C:\\Users\\VinhTong\\Documents\\person1.jpg";
        string test1 = "..\\..\\Image\\person1.jpg";
        string FilePath =  Application.StartupPath + "\\" + "Image\\person1.jpg";
        string str = System.IO.Directory.GetCurrentDirectory().ToString();
        int lastchuoi;
        public frmTestImagecs(string imageurl)
        {
            InitializeComponent();
            // _imageUrl = imageurl;
            lastchuoi = str.LastIndexOf("bin");
            str = FilePath.Substring(0, lastchuoi)+ "Image\\person1.jpg";
        }

        private void frmTestImagecs_Load(object sender, EventArgs e)
        {
            //FileInfo fi = new FileInfo(_imageUrl);
            // ReportParameter pName = new ReportParameter("pName", fi.Name);
           
            ReportParameter pImageUrl = new ReportParameter("pImageUrl", new Uri(str).AbsoluteUri);
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { pImageUrl });
            this.reportViewer1.RefreshReport();
        }
    }
}
