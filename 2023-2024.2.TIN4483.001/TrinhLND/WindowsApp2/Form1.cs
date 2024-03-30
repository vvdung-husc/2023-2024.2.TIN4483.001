using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát ứng dụng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void cbxUC_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void cbxBC_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        // hàm tìm ước chung lớn nhất  
        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // hàm tìm bội chung nhỏ nhất 
        private int BCNN(int a, int b)
        {
            return (a * b) / UCLN(a, b);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (cbxUC.Checked)
            {

            }
            else if (cbxBC.Checked)
            {

            }
            else
            {
                MessageBox.Show("Vui lòng chọn tìm UCLN hay BCNN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            int a, b;
            if (!int.TryParse(txtA.Text, out a) || !int.TryParse(txtB.Text, out b))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ.");
                return;
            }

            int result;
            if (cbxUC.Checked)
            {
                result = UCLN(a, b);
            }
            else
            {
                result = BCNN(a, b);
            }

            txtKQ.Text = "" + result;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtKQ.Text = "";
        }
    }
}
