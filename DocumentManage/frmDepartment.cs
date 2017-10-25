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
    public partial class frmDepartment : Form
    {
        DepartmentBUS de = new DepartmentBUS();
        public frmDepartment()
        {
            InitializeComponent();
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            gcData.DataSource = de.LoadData();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcData.DataSource = de.LoadData();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int row_index = gvData.FocusedRowHandle;
            if (row_index<0)
            {
                XtraMessageBox.Show("Vui lòng chọn dòng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string col_IDDepart = "IDDepart";
                string col_DepartName = "DepartName";
                string col_Description = "Description";
                object value_IDDepart = gvData.GetRowCellValue(row_index, col_IDDepart);
                object value_DepartName = gvData.GetRowCellValue(row_index, col_DepartName);
                object value_Description = gvData.GetRowCellValue(row_index, col_Description);
                frmDepartmentUpdate frm = new frmDepartmentUpdate(value_IDDepart.ToString(), value_DepartName.ToString(), value_Description.ToString());
                frm.ShowDialog();
                gcData.DataSource = de.LoadData();
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDepartmentUpdate frm = new frmDepartmentUpdate();
            frm.ShowDialog();
            gcData.DataSource = de.LoadData();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn chắc chắn muốn xóa dòng dữ liệu đang chọn", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int row_index = gvData.FocusedRowHandle;
                if (row_index >= 0)
                {
                    string col_file_name = "IDDepart";
                    object value = gvData.GetRowCellValue(row_index, col_file_name);
                    if (value != null)
                    {
                        de.DeleteDate(value.ToString());
                        XtraMessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gcData.DataSource = de.LoadData();
                    }
                    else
                    {
                        XtraMessageBox.Show("Vui lòng chọn dòng dữ liệu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
        }
    }
}
