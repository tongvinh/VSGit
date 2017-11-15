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
        string ToStore;
        public XtraReportImport()
        {
            InitializeComponent();
        }
        public XtraReportImport(int IDDocument,string ToStore)
        {
            InitializeComponent();
            this.IDDocument = IDDocument;
            this.ToStore = ToStore;
            objectDataSource1.DataSource = re.getInfo(IDDocument);
            objectDataSource2.DataSource = re.getDetails(IDDocument);
            pDoiSoThanhChu.Value = re.TienBangChuImport(IDDocument);
            pDoiSoThanhChu.Visible = false;
            //if (ToStore=="PL1")
            //{
            //    pThuKho.Value = "TRẦN MINH TẤN";
            //}
            //else if (ToStore=="VA1")
            //{
            //    pNguoiNhan.Value = "NGUYỄN THỊ KIM LOAN";
            //    pThuKho.Value = "TRẦN MINH TẤN";
            //}
            //else if (ToStore=="TP1")
            //{
            //    pNguoiNhan.Value = "HUỲNH THANH THỦY";
            //    pThuKho.Value = "PHẠM THỊ XUÂN";
            //}
        }
    }
}
