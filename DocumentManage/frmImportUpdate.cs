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
        string DocumentNumber, NoTK, CoTK, FromStore, ToStore, Description;
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
        public frmImportUpdate(int IDEmployee,int IDDocument, string NoTK, string CoTK, DateTime Date,string ToStore, string Description)
        {
            InitializeComponent();
            this.IDEmployee = IDEmployee;
            this.IDDocument = IDDocument;
            this.NoTK = NoTK;
            this.CoTK = CoTK;
            this.Date = Date;
            this.ToStore = ToStore;
            this.Description = Description;
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
        }

        private void btnLuuLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (flag)
            {
                if (dateImport.EditValue == null || cmbDepart.EditValue == null||txtDescription.EditValue==null)
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
                    im.UpdateData(IDDocument, notk, cotk, dt, tostore, des);
                    XtraMessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                if (dateImport.EditValue == null || cmbDepart.EditValue == null || txtDescription.EditValue == null)
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
                    string DocumnetNumber = "PNK_CC_" + iddoccument.ToString("D4") + "/" + Fromstore + "/" + Tostore;
                    im.InsertData(DocumnetNumber, Notk, Cotk, date, Fromstore, Tostore, Description, IDEmployee);
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
