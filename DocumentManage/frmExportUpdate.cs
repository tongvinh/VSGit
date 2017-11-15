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

namespace DocumentManage
{
    public partial class frmExportUpdate : Form
    {
        int IDDocument,IDEmployee;
        string NoTK, CoTK,FromStore, ToStore, Description,nguoinhan,bophan;
        DateTime Date;
        bool flag;
        ExportBUS ex = new ExportBUS();
        public frmExportUpdate()
        {
            InitializeComponent();
        }

        public frmExportUpdate(int IDEmployee)
        {
            InitializeComponent();
            this.IDEmployee = IDEmployee;
        }
        public frmExportUpdate(int IDEmployee,int IDDocument, string NoTK, string CoTK, DateTime Date,string FromStore, string ToStore, string Description,string bophan,string nguoinhan)
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
            this.bophan = bophan;
            this.nguoinhan = nguoinhan;
            flag = true;
        }
        private void frmExportUpdate_Load(object sender, EventArgs e)
        {
            cmbDepart.Properties.DataSource = ex.getDataDepart(IDEmployee);
            cmbDepart.Properties.ValueMember = "IDDepart";
            cmbDepart.Properties.DisplayMember = "DepartName";
            cmbFromTo.Properties.DataSource = ex.getFromStoreDepart();
            cmbFromTo.Properties.ValueMember = "IDDepart";
            cmbFromTo.Properties.DisplayMember = "DepartName";
            if (flag)
            {
                dateImport.EditValue = Date;
                txtNotk.EditValue = NoTK;
                txtCotk.EditValue = CoTK;
                cmbFromTo.EditValue = FromStore;
                cmbDepart.EditValue = ToStore;
                txtDescription.EditValue = Description;
                txtBophan.Text = bophan;
                txtNguoinhan.Text = nguoinhan;
            }
          
        }
        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnLuuLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (flag)
            {
                if (dateImport.EditValue == null || cmbDepart.EditValue == null||cmbFromTo.EditValue==null || txtDescription.EditValue == null)
                {
                    XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Focus();
                }
                else
                {   
                    
                    // sửa phiếu xuất
                    string notk = txtNotk.Text;
                    string cotk = txtCotk.Text;
                    DateTime dt = Convert.ToDateTime(dateImport.EditValue);
                    string fromstore = cmbFromTo.EditValue.ToString();
                    string tostore = cmbDepart.EditValue.ToString();
                    string des = txtDescription.Text;
                    // update sua phieu xuat
                    string DocumnetNumber = "PXK_CC_" + IDDocument.ToString("D4") + "/" + fromstore + "/" + tostore;
                    //
                    string nguoinhan = txtNguoinhan.Text;
                    string bophan = txtBophan.Text;
                    ex.UpdateData(IDDocument,DocumnetNumber, notk, cotk, dt,fromstore, tostore, des, bophan, nguoinhan);
                    XtraMessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
            }
            else
            {
                if (dateImport.EditValue == null || cmbDepart.EditValue == null||cmbFromTo.EditValue==null || txtDescription.EditValue == null)
                {
                    XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Focus();
                }
                else
                {
                    int iddoccument = ex.GetLastIdentity() + 1;
                    string Notk = txtNotk.Text;
                    string Cotk = txtCotk.Text;
                    DateTime date = Convert.ToDateTime(dateImport.EditValue.ToString());
                    //string Fromstore = ex.getFromStore(IDEmployee);
                    string fromstore = cmbFromTo.EditValue.ToString();
                    string Tostore = cmbDepart.EditValue.ToString();
                    string Description = txtDescription.Text;
                    string DocumnetNumber = "PXK_CC_" + iddoccument.ToString("D4") + "/" + fromstore + "/" + Tostore;
                    string Nguoinhan = txtNguoinhan.Text;
                    string Bophan = txtBophan.Text;
                    ex.InsertData(DocumnetNumber, Notk, Cotk, date, fromstore, Tostore, Description, IDEmployee, Bophan, Nguoinhan);
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
