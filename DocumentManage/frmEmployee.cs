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
    public partial class frmEmployee : Form
    {
        EmployeeBUS em = new EmployeeBUS();
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            gcData.DataSource = em.LoadData();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmEmployeeUpdate frm = new frmEmployeeUpdate();
            frm.ShowDialog();
            gcData.DataSource = em.LoadData();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcData.DataSource = em.LoadData();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn chắc chắn muốn xóa dòng dữ liệu đang chọn", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int row_index = gvData.FocusedRowHandle;
                if (row_index >= 0)
                {
                    string col_file_name = "IDEmployee";
                    object value = gvData.GetRowCellValue(row_index, col_file_name);
                    if (value != null)
                    {
                        em.DeleteDate(Convert.ToInt32(value.ToString()));
                        XtraMessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gcData.DataSource = em.LoadData();
                    }
                    else
                    {
                        XtraMessageBox.Show("Vui lòng chọn dòng dữ liệu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int row_index = gvData.FocusedRowHandle;
            if (row_index < 0)
            {
                XtraMessageBox.Show("Vui lòng chọn dòng dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string col_IDDepart = "IDDepart";
                string col_IDEmployee = "IDEmployee";
                string col_EmployeeName = "EmployeeName";
                object value_IDDepart = gvData.GetRowCellValue(row_index, col_IDDepart);
                object value_IDEmployee = gvData.GetRowCellValue(row_index, col_IDEmployee);
                object value_EmployeeName = gvData.GetRowCellValue(row_index, col_EmployeeName);
                frmEmployeeUpdate frm = new frmEmployeeUpdate(Convert.ToInt32(value_IDEmployee.ToString()), value_EmployeeName.ToString(), value_IDDepart.ToString());
                frm.ShowDialog();
                gcData.DataSource = em.LoadData();
            }
        }
    }
}
