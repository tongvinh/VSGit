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
    public partial class frmExportDetail : Form
    {
        int IDDocument;
        ExportDetailBUS ex = new ExportDetailBUS();
        public frmExportDetail()
        {
            InitializeComponent();
        }
        public frmExportDetail(int IDDocument)
        {
            InitializeComponent();
            this.IDDocument = IDDocument;
        }
        private void frmExportDetail_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            gcData.DataSource = ex.LoadData(IDDocument);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcData.DataSource = ex.LoadData(IDDocument);
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmExportDetailUpdate frm = new frmExportDetailUpdate(IDDocument);
            frm.ShowDialog();
            gcData.DataSource = ex.LoadData(IDDocument);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
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
                string col_IDDetail = "IDDetail";
                string col_StyleNo = "StyleNo";
                string col_MaterialStyle = "MaterialStyle";
                string col_MaterialDetails = "MaterialDetails";
                string col_Unit = "Unit";
                string col_NumberRequest = "NumberRequest";
                string col_NumberReceived = "NumberReceived";
                string col_Price = "Price";
                string col_TotalAmount = "TotalAmount";
                object value_IDDetail = gvData.GetRowCellValue(row_index, col_IDDetail);
                object value_StyleNo = gvData.GetRowCellValue(row_index, col_StyleNo);
                object value_MaterialStyle = gvData.GetRowCellValue(row_index, col_MaterialStyle);
                object value_MaterialDetails = gvData.GetRowCellValue(row_index, col_MaterialDetails);
                object value_Unit = gvData.GetRowCellValue(row_index, col_Unit);
                object value_NumberRequest = gvData.GetRowCellValue(row_index, col_NumberRequest);
                object value_NumberReceived = gvData.GetRowCellValue(row_index, col_NumberReceived);
                object value_Price = gvData.GetRowCellValue(row_index, col_Price);
                object value_TotalAmount = gvData.GetRowCellValue(row_index, col_TotalAmount);
                frmExportDetailUpdate frm = new frmExportDetailUpdate(Convert.ToInt32(value_IDDetail.ToString()), value_StyleNo.ToString(), value_MaterialStyle.ToString(), value_MaterialDetails.ToString(), value_Unit.ToString(), float.Parse(value_NumberRequest.ToString()), float.Parse(value_NumberReceived.ToString()), decimal.Parse(value_Price.ToString()), decimal.Parse(value_TotalAmount.ToString()));
                frm.ShowDialog();
                gcData.DataSource = ex.LoadData(IDDocument);
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn chắc chắn muốn xóa dòng dữ liệu đang chọn", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int row_index = gvData.FocusedRowHandle;
                if (row_index >= 0)
                {
                    string col_file_name = "IDDetail";
                    object value = gvData.GetRowCellValue(row_index, col_file_name);
                    if (value != null)
                    {
                        ex.DeleteData(Convert.ToInt32(value.ToString()));
                        XtraMessageBox.Show("Xóa dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gcData.DataSource = ex.LoadData(IDDocument);
                    }
                    else
                    {
                        XtraMessageBox.Show("Vui lòng chọn dòng dữ liệu cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmReportDocumentExport frm = new frmReportDocumentExport(IDDocument);
            frm.ShowDialog();
        }
    }
}
