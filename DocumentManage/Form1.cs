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
    public partial class frmLogin : Form
    {
        AccountBUS ac = new AccountBUS();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cmbDepartment.EditValue==null||txtPass.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string iddepas = cmbDepartment.EditValue.ToString();
                int idemployee = Convert.ToInt32(txtPass.Text.ToString());
                bool kt = ac.Dangnhap(iddepas, idemployee);
                if (kt)
                {
                    MainForm frm = new MainForm(idemployee);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Username hoặc password không đúng, Vui lòng kiểm tra lại hoặc liên hệ: Vinh Tống");
                }
            }
           
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cmbDepartment.Properties.DataSource = ac.GetDepart();
            cmbDepartment.Properties.ValueMember = "IDDepart";
            cmbDepartment.Properties.DisplayMember = "DepartName";
        }
    }
}
