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
    public partial class Form2 : Form
    {
        DoiSo d = new DoiSo();
        public Form2()
        {
            InitializeComponent();
        }
        string imageUrl = null;
        private void Form2_Load(object sender, EventArgs e)
        {
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imageUrl = ofd.FileName;
                    pictureBox.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(imageUrl))
            {
                using(frmTestImagecs frm=new frmTestImagecs(imageUrl))
                {
                    frm.ShowDialog();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(d.ChuyenSo("120001")+" đồng");
        }
    }
}
