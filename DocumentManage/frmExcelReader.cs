using DevExpress.DataAccess.Excel;
using System;
using System.Windows.Forms;
using BUS;
using DevExpress.XtraEditors;

namespace DocumentManage
{
    public partial class frmExcelReader : Form
    {
        ImportDetailBUS im = new ImportDetailBUS();
        ExcelDataSource myExcelSource = new ExcelDataSource();
        int IDDocument;
        public frmExcelReader()
        {
            InitializeComponent();
        }
        public frmExcelReader(int IDDocument)
        {
            InitializeComponent();
            this.IDDocument = IDDocument;
        }
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            using (OpenFileDialog ofd=new OpenFileDialog() { Filter="Excel Workbook|*.xlsx",ValidateNames=true})
            {
                if (ofd.ShowDialog()==DialogResult.OK)
                {
                    try
                    {
                        myExcelSource.FileName = ofd.FileName;
                        ExcelWorksheetSettings worksheetSettings = new ExcelWorksheetSettings("Data", "A1:L100");
                        myExcelSource.SourceOptions = new ExcelSourceOptions(worksheetSettings);
                        myExcelSource.Fill();
                        gcData.DataSource = myExcelSource;
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Phải đặt tên sheet trong file Excel là Data", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                  
                }
                

            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cmbOptionSheet_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string tyleno;
            string mastyle;
            string madetails;
            string unit;
            float numberRequest, numberReceived;
            decimal price;
            decimal totalAmount = 0;
            string col_StyleNo = "StyleNo";
            string col_MaterialStyle = "Items";
            string col_MaterialDetails = "Details";
            string col_Unit = "Unit";
            string col_NumberRequest = "Packing List";
            string col_NumberReceived = "Actual Received";
            string col_Price = "Price";
            string col_TotalAmount = "TotalAmount";
            if (gvData.RowCount<=0)
            {
                XtraMessageBox.Show("Chưa mở file excel", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (int i = 0; i < gvData.RowCount; i++)
                {
                    object value_StyleNo = gvData.GetRowCellValue(i, col_StyleNo);
                    object value_MaterialStyle = gvData.GetRowCellValue(i, col_MaterialStyle);
                    object value_MaterialDetails = gvData.GetRowCellValue(i, col_MaterialDetails);
                    object value_Unit = gvData.GetRowCellValue(i, col_Unit);
                    object value_NumberRequest = gvData.GetRowCellValue(i, col_NumberRequest);
                    object value_NumberReceived = gvData.GetRowCellValue(i, col_NumberReceived);
                    object value_Price = gvData.GetRowCellValue(i, col_Price);
                    object value_TotalAmount = gvData.GetRowCellValue(i, col_TotalAmount);
                    try
                    {
                        tyleno = value_StyleNo.ToString();
                        mastyle = value_MaterialStyle.ToString();
                        madetails = value_MaterialDetails.ToString();
                        unit = value_Unit.ToString();
                        numberRequest = float.Parse(value_NumberRequest.ToString());
                        numberReceived = float.Parse(value_NumberReceived.ToString());
                        price = decimal.Parse(value_Price.ToString());
                        totalAmount = decimal.Parse(value_TotalAmount.ToString());
                        im.InsertData(IDDocument, tyleno, mastyle, madetails, unit, numberRequest, numberReceived, price, totalAmount);

                    }
                    catch (Exception)
                    {

                        XtraMessageBox.Show("Định dạng trong file Excel không đúng, Kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                XtraMessageBox.Show("Nhập dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        
                
        }
    }
}
