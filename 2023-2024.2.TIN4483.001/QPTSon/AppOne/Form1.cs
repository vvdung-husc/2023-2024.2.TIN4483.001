using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        

        private void txtExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTim_Click(object sender, EventArgs e)
        {
            if (txtUCLN.Checked)
            {
                MessageBox.Show("Đang chọn UCLN => Tính kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtBCNN.Checked)
            {
                MessageBox.Show("Đang chọn BCNN => Tính kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tìm UCLN hay BCNN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtNext_Click_1(object sender, EventArgs e)
        {
            txtNhapA.Text = "";
            txtNhapB.Text = "";
        }

        private void txtBCNN_CheckedChanged_1(object sender, EventArgs e)
        {
            txtTim.Text = "Tìm - BCNN";
        }

        private void txtUCLN_CheckedChanged(object sender, EventArgs e)
        {
            txtTim.Text = "Tìm - UCLN";

        }
       
    }
}
