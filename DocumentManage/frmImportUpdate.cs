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
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;

namespace DocumentManage
{
    public partial class frmImportUpdate : Form
    {
        int IDEmployee,IDDocument;
        string DocumentNumber, NoTK, CoTK, FromStore, ToStore, Description,nguoigiao,bophan,SoHD,SoPO,HTThanhToan,PTVanChuyen,DVTien;
        DateTime Date;
        bool flag;
        ImportBUS im = new ImportBUS();
        public frmImportUpdate()
        {
            InitializeComponent();
        }
        public frmImportUpdate(int IDEmployee)
        {
            InitializeComponent();
            this.IDEmployee = IDEmployee;
        }
        public frmImportUpdate(int IDEmployee,int IDDocument, string NoTK, string CoTK, DateTime Date,string FromStore,string ToStore, string Description,string nguoigiao,string bophan,string SoHD,string SoPO,string HTThanhToan,string PTVanChuyen,string DVTien)
        {
            InitializeComponent();
            this.IDEmployee = IDEmployee;
            this.IDDocument = IDDocument;
            this.NoTK = NoTK;
            this.CoTK = CoTK;
            this.Date = Date;
            this.FromStore = FromStore;
            this.ToStore = ToStore;
            this.Description = Description;
            this.nguoigiao = nguoigiao;
            this.bophan = bophan;
            this.SoHD = SoHD;
            this.SoPO = SoPO;
            this.HTThanhToan = HTThanhToan;
            this.PTVanChuyen = PTVanChuyen;
            this.DVTien = DVTien;
            flag = true;
        }
        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmImportUpdate_Load(object sender, EventArgs e)
        {
            cmbDepart.Properties.DataSource = im.getDataDepart(IDEmployee);
            cmbDepart.Properties.ValueMember = "IDDepart";
            cmbDepart.Properties.DisplayMember = "DepartName";

            dateImport.EditValue = Date;
            txtNotk.EditValue = NoTK;
            txtCotk.EditValue = CoTK;
            cmbDepart.EditValue = ToStore;
            txtDescription.EditValue = Description;
            txtBoPhan.EditValue = bophan;
            txtNguoiGiao.EditValue = nguoigiao;
            this.txtSoHD.EditValue = this.SoHD;
            this.txtSoPO.EditValue = this.SoPO;
            this.txtHTThanhToan.EditValue = this.HTThanhToan;
            this.txtPTVanChuyen.EditValue = this.PTVanChuyen;
            this.txtDVTien.EditValue = this.DVTien;
        }

        private void btnLuuLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (flag)
            {
                if (dateImport.EditValue == null || cmbDepart.EditValue == null||txtDescription.EditValue==null||txtNguoiGiao.EditValue==null||txtBoPhan.EditValue==null)
                {
                    XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Focus();
                }
                else
                {
                    string notk = txtNotk.Text;
                    string cotk = txtCotk.Text;
                    DateTime dt = Convert.ToDateTime(dateImport.EditValue);
                    string tostore = cmbDepart.EditValue.ToString();
                    string des = txtDescription.Text;
                    //Update Document number
                    string DocumnetNumber = "PNK_CC_" + IDDocument.ToString("D4") + "/" + FromStore + "/" + tostore;
                    //
                    string nguoigiao = txtNguoiGiao.Text;
                    string bophan = txtBoPhan.Text;
                    //update 11/12
                    string SoHD = this.txtSoHD.Text;
                    string SoPO = this.txtSoPO.Text;
                    string HTThanhToan = this.txtHTThanhToan.Text;
                    string PTVanChuyen = this.txtPTVanChuyen.Text;
                    string DVTien = this.txtDVTien.Text;
                    im.UpdateData(IDDocument,DocumnetNumber, notk, cotk, dt, tostore, des, bophan, nguoigiao,SoHD,SoPO,HTThanhToan,PTVanChuyen,DVTien);
                    XtraMessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                if (dateImport.EditValue == null || cmbDepart.EditValue == null || txtDescription.EditValue == null||txtBoPhan.EditValue==null||txtNguoiGiao==null)
                {
                    XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Focus();
                }
                else
                {
                    int iddoccument = im.GetLastIdentity() + 1;
                    string Notk = txtNotk.Text;
                    string Cotk = txtCotk.Text;
                    DateTime date = Convert.ToDateTime(dateImport.EditValue.ToString());
                    string Fromstore = im.getFromStore(IDEmployee);
                    string Tostore = cmbDepart.EditValue.ToString();
                    string Description = txtDescription.Text;
                    string nguoigiao = txtNguoiGiao.Text;
                    string bophan = txtBoPhan.Text;
                    string DocumnetNumber = "PNK_CC_" + iddoccument.ToString("D4") + "/" + Fromstore + "/" + Tostore;
                    //Update 11/12
                    string SoHD = this.txtSoHD.Text;
                    string SoPO = this.txtSoPO.Text;
                    string HTThanhToan = this.txtHTThanhToan.Text;
                    string PTVanChuyen = this.txtPTVanChuyen.Text;
                    string DVTien = this.txtDVTien.Text;
                    im.InsertData(DocumnetNumber, Notk, Cotk, date, Fromstore, Tostore, Description, IDEmployee, bophan, nguoigiao,SoHD,SoPO,HTThanhToan,PTVanChuyen,DVTien);
                    XtraMessageBox.Show("Nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNotk.EditValue = null;
                    txtCotk.EditValue = null;
                    dateImport.EditValue = null;
                    txtDescription.EditValue = null;
                    cmbDepart.EditValue = null;
                }
            }
        }
    }
}
