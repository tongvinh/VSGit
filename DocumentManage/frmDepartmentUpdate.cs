using DevExpress.XtraEditors;
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
    public partial class frmDepartmentUpdate : Form
    {
        string IDDepart, DepartName, Description;
        bool flag = false;
        Boolean HD;
        DepartmentBUS d = new DepartmentBUS();
        public frmDepartmentUpdate()
        {
            InitializeComponent();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnLuuLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool hd;
            if (flag == true)
            {
                if (txtIDDepart.EditValue == null || txtDepartName.EditValue == null)
                {
                    XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Focus();
                }
                else
                {
                    string id = txtIDDepart.Text;
                    string name = txtDepartName.Text;
                    string des = txtDescription.Text;
                    if (ckHD.Checked)
                    {
                        hd = true;
                    }
                    else
                        hd = false;
                    d.UpdateData(id, name, des,hd);
                    XtraMessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                if (txtIDDepart.EditValue == null || txtDepartName.EditValue == null)
                {
                    XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Focus();
                }
                else
                { 
                    string id = txtIDDepart.Text;
                    string name = txtDepartName.Text;
                    string des = txtDescription.Text;
                    if (ckHD.Checked)
                    {
                        hd = true;
                    }
                    else
                        hd = false;
                    d.InsertData(id, name, des, hd);
                    XtraMessageBox.Show("Nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtIDDepart.EditValue = null;
                    txtDepartName.EditValue = null;
                    txtDescription.EditValue = null;

                }
            }
        }

        public frmDepartmentUpdate(string IDDepart, string DepartName, string Description,Boolean HD)
        {
            this.IDDepart = IDDepart;
            this.DepartName = DepartName;
            this.Description = Description;
            this.HD = HD;
            flag = true;
            InitializeComponent();
            txtIDDepart.Enabled = false;
        }
        private void frmDepartmentUpdate_Load(object sender, EventArgs e)
        {
            if (flag)
            {
                txtIDDepart.EditValue = IDDepart;
                txtDepartName.EditValue = DepartName;
                txtDescription.EditValue = Description;
                ckHD.EditValue = HD;
            }
        }
    }
}
