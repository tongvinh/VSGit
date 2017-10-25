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
    public partial class frmEmployeeUpdate : Form
    {
        EmployeeBUS em = new EmployeeBUS();
        int IDEmployee;
        string EmployeeName, IDDepart;
        bool flag = false;
        public frmEmployeeUpdate()
        {
            InitializeComponent();
        }
        public frmEmployeeUpdate(int IDEmployee,string EmployeeName,string IDDepart)
        {
            this.IDEmployee = IDEmployee;
            this.EmployeeName = EmployeeName;
            this.IDDepart = IDDepart;
            InitializeComponent();
            flag = true;
            txtEmployee.Enabled = false;
        }
        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmEmployeeUpdate_Load(object sender, EventArgs e)
        {
            cmbDepartment.Properties.DataSource = em.LoadDepartment();
            cmbDepartment.Properties.DisplayMember = "DepartName";
            cmbDepartment.Properties.ValueMember = "IDDepart";

            if (flag)
            {
                cmbDepartment.EditValue = IDDepart;
                txtEmployee.EditValue = IDEmployee;
                txtEmployeeName.EditValue = EmployeeName;
            }
        }

        private void btnLuuLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (flag == true)
            {
                if (cmbDepartment.EditValue == null || txtEmployee.EditValue == null||txtEmployeeName.EditValue==null)
                {
                    XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Focus();
                }
                else
                {
                    int id = Convert.ToInt32(txtEmployee.EditValue.ToString());
                    string name = txtEmployeeName.EditValue.ToString();
                    string iddes = cmbDepartment.EditValue.ToString();
                    em.UpdateData(id, name, iddes);
                    XtraMessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                if (cmbDepartment.EditValue == null || txtEmployee.EditValue == null || txtEmployeeName.Text == null)
                {
                    XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Focus();
                }
                else
                {
                    int id = Convert.ToInt32(txtEmployee.EditValue.ToString());
                    string name = txtEmployeeName.EditValue.ToString();
                    string idDespart = cmbDepartment.EditValue.ToString();
                    em.InsertData(id, name, idDespart);
                    XtraMessageBox.Show("Nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmployee.EditValue = null;
                    txtEmployeeName.EditValue = null;
                    cmbDepartment.EditValue = null;

                }
            }  
        }
    }
}
