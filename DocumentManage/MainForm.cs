using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentManage
{
    public partial class MainForm : Form
    {
        int IDEmployee;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(int IDEmployee)
        {
            InitializeComponent();
            this.IDEmployee = IDEmployee;
        }
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name==name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name==name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmDepartment"))
            {
                frmDepartment frm = new frmDepartment();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("frmDepartment");
            
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmEmployee"))
            {
                frmEmployee frm = new frmEmployee();
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("frmEmployee");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmImport"))
            {
                frmImport frm = new frmImport(IDEmployee);
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("frmImport");
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmExport"))
            {
                frmExport frm = new frmExport(IDEmployee);
                frm.MdiParent = this;
                frm.Show();
            }
            else
                ActiveChildForm("frmExport");
        }
    }
}
