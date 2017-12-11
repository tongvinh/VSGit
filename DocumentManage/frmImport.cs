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
using DevExpress.XtraGrid.Views.Grid;

namespace DocumentManage
{
    public partial class frmImport : Form
    {
        ImportBUS im = new ImportBUS();
        int IDEmployee;
        public frmImport()
        {
            InitializeComponent();
        }
        public frmImport(int IDEmployee)
        {
            InitializeComponent();
            this.IDEmployee = IDEmployee;
        }
        private void frmImport_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.gcData.DataSource = im.loaddata();
            this.btnSua.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gcData.DataSource = im.loaddata();
        }

        private void BtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmImportUpdate frm = new frmImportUpdate(this.IDEmployee);
            frm.ShowDialog();
            this.gcData.DataSource = this.im.loaddata();
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
                string col_FromStore = "FromStore";
                string col_ToStore = "ToStore";
                string col_Description = "Description";
                string col_nguoigiao = "PersonSent";
                string col_bophan = "PartSent";
                //Update 11/12
                string col_SoHD = "SoHD";
                string col_SoPO = "SoPO";
                string col_HTThanhToan = "HTThanhToan";
                string col_PTVanChuyen = "PTVanChuyen";
                string col_DVTien = "DVTien";

                string cotk, notk, des,nguoigiao,bophan;

                object value_IDDocument = gvData.GetRowCellValue(row_index, col_IDDocument);
                object value_CoTK= gvData.GetRowCellValue(row_index, col_CoTK);
                object value_NoTK= gvData.GetRowCellValue(row_index, col_NoTK);
                object value_Date= gvData.GetRowCellValue(row_index, col_Date);
                object value_ToFromStore = gvData.GetRowCellValue(row_index, col_FromStore);
                object value_ToStore= gvData.GetRowCellValue(row_index, col_ToStore);
                object value_Description = gvData.GetRowCellValue(row_index, col_Description);
                object value_Nguoigiao = gvData.GetRowCellValue(row_index, col_nguoigiao);
                object value_Bophan = gvData.GetRowCellValue(row_index, col_bophan);
                //Update 11/12
                object value_SoHD = gvData.GetRowCellValue(row_index, col_SoHD);
                object value_SoPO = gvData.GetRowCellValue(row_index, col_SoPO);
                object value_HTThanhToan = gvData.GetRowCellValue(row_index, col_HTThanhToan);
                object value_PTVanChuyen = gvData.GetRowCellValue(row_index, col_PTVanChuyen);
                object value_DVTien = gvData.GetRowCellValue(row_index, col_DVTien);

                if (value_CoTK == null)
                {
                    cotk = "";
                }
                else
                {
                    cotk = value_CoTK.ToString();
                }
                if (value_NoTK==null)
                {
                    notk = "";
                }
                else
                {
                    notk = value_NoTK.ToString();
                }
                if (value_Description==null)
                {
                    des = "";
                }
                else
                {
                    des = value_Description.ToString();
                }
                if (value_Nguoigiao==null)
                {
                    nguoigiao = "";
                }
                else
                {
                    nguoigiao = value_Nguoigiao.ToString();
                }
                if (value_Bophan == null)
                {
                    bophan = "";
                }
                else
                {
                    bophan = value_Bophan.ToString();
                }
                frmImportUpdate frm = new frmImportUpdate(
                    this.IDEmployee,
                    Convert.ToInt32(value_IDDocument.ToString()),
                    notk,
                    cotk,
                    Convert.ToDateTime(value_Date),
                    value_ToFromStore.ToString(),
                    value_ToStore.ToString(),
                    des,
                    nguoigiao,
                    bophan,
                    value_SoHD==null?"":value_SoHD.ToString(),
                    value_SoPO==null?"":value_SoPO.ToString(),
                    value_HTThanhToan==null?"":value_HTThanhToan.ToString(),
                    value_PTVanChuyen==null?"":value_PTVanChuyen.ToString(),
                    value_DVTien==null?"":value_DVTien.ToString());
                frm.ShowDialog();
                this.gcData.DataSource = this.im.loaddata();
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
                int row_index = this.gvData.FocusedRowHandle;
                if (row_index >= 0)
                {
                    string col_IDDocument = "IDDocument";
                    object value_IDDocument = this.gvData.GetRowCellValue(row_index, col_IDDocument);
                    string col_ToStore = "ToStore";
                    object value_ToStore = this.gvData.GetRowCellValue(row_index, col_ToStore);
                    frmImportDetail f = new frmImportDetail(Convert.ToInt32(value_IDDocument), value_ToStore.ToString());
                    f.MdiParent = this.ParentForm;
                    f.Show();
                }
            }
        }

        private void gvData_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
        {
            
        }

        private void gvData_Click(object sender, EventArgs e)
        {
            int row_index = this.gvData.FocusedRowHandle;
            string col_IDEmployee = "IDEmployee";
            object value_IDEmployee = this.gvData.GetRowCellValue(row_index, col_IDEmployee);
            this.btnSua.Enabled = int.Parse(value_IDEmployee.ToString()) == this.IDEmployee;
        }
    }
}
