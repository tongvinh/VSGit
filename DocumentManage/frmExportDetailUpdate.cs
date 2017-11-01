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
    public partial class frmExportDetailUpdate : Form
    {
        ExportDetailBUS ex = new ExportDetailBUS();
        int IDDocument, IDDetail;
        string tyleno;
        string mastyle;
        string madetails;
        string unit;
        float numberRequest, numberReceived;
        decimal price;
        decimal totalAmount = 0;
        bool flag;
        public frmExportDetailUpdate()
        {
            InitializeComponent();
        }
        public frmExportDetailUpdate(int IDDocument)
        {
            InitializeComponent();
            this.IDDocument = IDDocument;
        }
        public frmExportDetailUpdate(int IDDetail, string StyleNo, string MaStyle, string maDetails, string Unit, float numberRequest, float numberReceived, decimal price, decimal totalAmount)
        {
            InitializeComponent();
            this.IDDetail = IDDetail;
            this.tyleno = StyleNo;
            this.mastyle = MaStyle;
            this.madetails = maDetails;
            this.unit = Unit;
            this.numberRequest = numberRequest;
            this.numberReceived = numberReceived;
            this.unit = Unit;
            this.numberRequest = numberRequest;
            this.numberReceived = numberReceived;
            this.price = price;
            this.totalAmount = totalAmount;
            flag = true;
        }
        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        
        private void frmExportDetailUpdate_Load(object sender, EventArgs e)
        {
            initLookupEditStyle();
            initLookupEditDetails();
            initLookupEditUnits();
            if (flag)
            {
                txtStyleNo.EditValue = tyleno;
                cmbMaStyle.EditValue = mastyle;
                cmbMaDetails.EditValue = madetails;
                cmbUnit.EditValue = unit;
                txtNumberRequest.EditValue = numberRequest;
                txtNumberReceived.EditValue = numberReceived;
                txtPrice.EditValue = price;
            }
        }
        void initLookupEditStyle()
        {
            
            cmbMaStyle.Properties.NullText = "";
            string[] value = new string[] { "SHELL", "LINING","SHOULDER PAD","C BAND","BUTTON","THREAD","MAIN LABEL","SIZE LABEL","PRICE TAG" };
            cmbMaStyle.Properties.DataSource = value;
            cmbMaStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }
        void initLookupEditDetails()
        {

            cmbMaDetails.Properties.NullText = "";
            string[] value = new string[] { "100% Cotton", "100% Polyester", "70% Cotton 30% Polyester", "100% Nylon", "100% Wool","12MM White","12MM Black",
            "15MM White","15MM Black","20MM White","20MM Black","25MM White","25MM Black","30MM White","30MM Black","32MM White","32MM Black",
            "G-28-4MM","NK-04-4MM","NK-04-2MM","38MM White","38MM Black","50MM White","50MM Black","10MM","15MM","18MM","21MM","23MM","25MM",
            "60S/2","60S/3","45S/2","16S/3","29S/3","70D/2","20S/3","20S/4","20S/9","30S/3","50S/3","100D/1","EMIL 011P White","EMIL 011p Black",
            "EMIL 012P White","EMIL 012P Black","EMIL 013P White","EMIL 013P Black","EMIL 014P White","EMIL 014P Black","EMIL 015P White","EMIL 015P Black",
            "S White","M White","L White","S Black","M Black","L Black","24 White","26 White","28 White","30 White","24 Black","26 Black","28 Black","30 Black"};
            cmbMaDetails.Properties.DataSource = value;
            cmbMaDetails.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }
        void initLookupEditUnits()
        {

            cmbUnit.Properties.NullText = "";
            string[] value = new string[] { "MÉT", "YA", "THÙNG", "CUỘN","PCS" };
            cmbUnit.Properties.DataSource = value;
            cmbUnit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }

        private void btnLuuLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (flag)
            {
                if (txtStyleNo.EditValue == null || cmbMaStyle.EditValue == null || cmbUnit.EditValue == null)
                {
                    XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Focus();
                }
                else
                {
                    string tyleno = txtStyleNo.Text;
                    string mastyle = cmbMaStyle.Text;
                    string madetails = cmbMaDetails.Text;
                    string unit = cmbUnit.Text;
                    float numberRequest, numberReceived;
                    decimal price;
                    decimal totalAmount = 0;
                    if (txtNumberReceived.EditValue == null)
                    {
                        numberReceived = 0;
                    }
                    else
                    {
                        numberReceived = float.Parse(txtNumberReceived.EditValue.ToString());
                    }
                    if (txtNumberRequest.EditValue == null)
                    {
                        numberRequest = 0;
                    }
                    else
                    {
                        numberRequest = float.Parse(txtNumberRequest.EditValue.ToString());
                    }
                    if (txtPrice.EditValue == null)
                    {
                        price = 0;
                    }
                    else
                    {
                        price = decimal.Parse(txtPrice.EditValue.ToString());
                        totalAmount = (decimal.Parse(numberReceived.ToString()) * price);
                    }
                    //if (txtNumberReceived.EditValue == null || txtNumberRequest.EditValue == null || txtPrice.EditValue == null)
                    //{
                    //    numberReceived = 0;
                    //    numberRequest = 0;
                    //    price = 0;
                    //}
                    //else
                    //{
                    //    numberReceived = float.Parse(txtNumberReceived.EditValue.ToString());
                    //    numberRequest = float.Parse(txtNumberRequest.EditValue.ToString());
                    //    price = decimal.Parse(txtPrice.EditValue.ToString());
                    //    totalAmount = (decimal.Parse(numberReceived.ToString()) * price);
                    //}
                    ex.UpdateData(IDDetail, tyleno, mastyle, madetails, unit, numberRequest, numberReceived, price, totalAmount);
                    XtraMessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                if (txtStyleNo.EditValue == null || cmbMaStyle.EditValue == null || cmbUnit.EditValue == null)
                {
                    XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Focus();
                }

                else
                {
                    string tyleno = txtStyleNo.Text;
                    string mastyle = cmbMaStyle.Text;
                    string madetails = cmbMaDetails.Text;
                    string unit = cmbUnit.Text;
                    float numberRequest, numberReceived;
                    decimal price;
                    decimal totalAmount = 0;
                    if (txtNumberReceived.EditValue == null )
                    {
                        numberReceived = 0;
                    }
                    else
                    {
                        numberReceived = float.Parse(txtNumberReceived.EditValue.ToString());
                    }
                    if (txtNumberRequest.EditValue == null)
                    {
                        numberRequest = 0;
                    }
                    else
                    {
                        numberRequest = float.Parse(txtNumberRequest.EditValue.ToString());
                    }
                    if (txtPrice.EditValue == null)
                    {
                        price = 0;
                    }
                    else
                    {
                        price = decimal.Parse(txtPrice.EditValue.ToString());
                        totalAmount = (decimal.Parse(numberReceived.ToString()) * price);
                    }
                    ex.InsertData(IDDocument, tyleno, mastyle, madetails, unit, numberRequest, numberReceived, price, totalAmount);
                    XtraMessageBox.Show("Nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtStyleNo.EditValue = null;
                    txtNumberReceived.EditValue = null;
                    txtNumberRequest.EditValue = null;
                    txtPrice.EditValue = null;
                    cmbMaDetails.Text = null;
                    cmbMaStyle.Text = null;
                    cmbUnit.Text = null;
                }
            }
        }
    }
}
