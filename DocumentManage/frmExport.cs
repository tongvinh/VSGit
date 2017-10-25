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
    public partial class frmExport : Form
    {
        ExportBUS ex = new ExportBUS();
        int IDEmployee;
        public frmExport()
        {
            InitializeComponent();
        }
        public frmExport(int IDEmployee)
        {
            InitializeComponent();
            this.IDEmployee = IDEmployee;

        }
        private void frmExport_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            gcData.DataSource = ex.loaddata();
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcData.DataSource = ex.loaddata();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmExportUpdate frm = new frmExportUpdate(IDEmployee);
            frm.ShowDialog();
            gcData.DataSource = ex.loaddata();
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
                string col_IDDocument = "IDDocument";
                string col_CoTK = "CoTK";
                string col_NoTK = "NoTK";
                string col_Date = "Date";
                string col_ToStore = "ToStore";
                string col_Description = "Description";

                string cotk, notk, des;

                object value_IDDocument = gvData.GetRowCellValue(row_index, col_IDDocument);
                object value_CoTK = gvData.GetRowCellValue(row_index, col_CoTK);
                object value_NoTK = gvData.GetRowCellValue(row_index, col_NoTK);
                object value_Date = gvData.GetRowCellValue(row_index, col_Date);
                object value_ToStore = gvData.GetRowCellValue(row_index, col_ToStore);
                object value_Description = gvData.GetRowCellValue(row_index, col_Description);
                if (value_CoTK == null)
                {
                    cotk = "";
                }
                else
                {
                    cotk = value_CoTK.ToString();
                }
                if (value_NoTK == null)
                {
                    notk = "";
                }
                else
                {
                    notk = value_NoTK.ToString();
                }
                if (value_Description == null)
                {
                    des = "";
                }
                else
                {
                    des = value_Description.ToString();
                }
                frmExportUpdate frm = new frmExportUpdate(IDEmployee,Convert.ToInt32(value_IDDocument.ToString()), notk, cotk, Convert.ToDateTime(value_Date), value_ToStore.ToString(), des);
                frm.ShowDialog();
                gcData.DataSource = ex.loaddata();
            }
        }

        private void gvData_DoubleClick(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["frmImportDetail"];
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                int row_index = gvData.FocusedRowHandle;
                if (row_index >= 0)
                {
                    string col_IDDocument = "IDDocument";
                    object value_IDDocument = gvData.GetRowCellValue(row_index, col_IDDocument);
                    frmExportDetail f = new frmExportDetail(Convert.ToInt32(value_IDDocument));
                    f.MdiParent = this.ParentForm;
                    f.Show();
                }
            }
        }
    }
}
