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
    public partial class frmImportDetailUpdate : Form
    {
        ImportDetailBUS im = new ImportDetailBUS();
        int IDDocument,IDDetail;
        string tyleno;
        string mastyle;
        string madetails;
        string unit;
        float numberRequest, numberReceived;
        decimal price;
        decimal totalAmount = 0;
        bool flag;
        public frmImportDetailUpdate()
        {
            InitializeComponent();
        }
        public frmImportDetailUpdate(int IDDocument)
        {
            InitializeComponent();
            this.IDDocument = IDDocument;
        }
        public frmImportDetailUpdate(int IDDetail,string StyleNo,string MaStyle,string maDetails, string Unit,float numberRequest,float numberReceived,decimal price,decimal totalAmount)
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

        private void frmImportDetailUpdate_Load(object sender, EventArgs e)
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
            string[] value = new string[] { "SHELL", "LINING" };
            cmbMaStyle.Properties.DataSource = value;
            cmbMaStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }
        void initLookupEditDetails()
        {

            cmbMaDetails.Properties.NullText = "";
            string[] value = new string[] { "100% Cotton", "100% Polyester", "70% Cotton 30% Polyester","100% Nylon","100% Wool" };
            cmbMaDetails.Properties.DataSource = value;
            cmbMaDetails.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }
        void initLookupEditUnits()
        {

            cmbUnit.Properties.NullText = "";
            string[] value = new string[] { "MÉT", "YA", "THÙNG","CUỘN" };
            cmbUnit.Properties.DataSource = value;
            cmbUnit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }

        private void btnLuuLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (flag)
            {
                if (txtStyleNo.EditValue == null || cmbMaStyle.EditValue == null || cmbMaDetails.EditValue == null || cmbUnit.EditValue == null)
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
                    if (txtNumberReceived.EditValue == null || txtNumberRequest.EditValue == null || txtPrice.EditValue == null)
                    {
                        numberReceived = 0;
                        numberRequest = 0;
                        price = 0;
                    }
                    else
                    {
                        numberReceived = float.Parse(txtNumberReceived.EditValue.ToString());
                        numberRequest = float.Parse(txtNumberRequest.EditValue.ToString());
                        price = decimal.Parse(txtPrice.EditValue.ToString());
                        totalAmount = (decimal.Parse(numberReceived.ToString()) * price);
                    }
                    im.UpdateData(IDDetail, tyleno, mastyle, madetails, unit, numberRequest, numberReceived, price, totalAmount);
                    XtraMessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                if (txtStyleNo.EditValue == null || cmbMaStyle.EditValue == null || cmbMaDetails.EditValue == null || cmbUnit.EditValue == null)
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
                    if (txtNumberReceived.EditValue == null || txtNumberRequest.EditValue == null || txtPrice.EditValue == null)
                    {
                        numberReceived = 0;
                        numberRequest = 0;
                        price = 0;
                    }
                    else
                    {
                        numberReceived = float.Parse(txtNumberReceived.EditValue.ToString());
                        numberRequest = float.Parse(txtNumberRequest.EditValue.ToString());
                        price = decimal.Parse(txtPrice.EditValue.ToString());
                        totalAmount = (decimal.Parse(numberReceived.ToString()) * price);
                    }
                    im.InsertData(IDDocument, tyleno, mastyle, madetails, unit, numberRequest, numberReceived, price, totalAmount);
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
