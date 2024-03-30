using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApptwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chkBSCNN_CheckedChanged(object sender, EventArgs e)
        {
            btntim.Text = "Tìm - BSCNN";
        }

        private void chkUSCLN_CheckedChanged(object sender, EventArgs e)
        {
            btntim.Text = "Tìm - USCLN";
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtNumA.Text = "";
            txtNumB.Text = "";
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            if (chkUSCLN.Checked)
            {
                MessageBox.Show("Đang chọn USCLN => Tính kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (chkBSCNN.Checked)
            {
                MessageBox.Show("Đang chọn BSCNN => Tính kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tìm USCLN hay BSCNN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            int a, b;
            if (!int.TryParse(txtNumA.Text, out a) || !int.TryParse(txtNumB.Text, out b))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ.");
                return;
            }

            int result;
            if (chkUSCLN.Checked)
            {
                result = USCLN(a, b);
            }
            else
            {
                result = USCNN(a, b);
            }

            groupbox3.Text = "" + result;
        }


        // Hàm tìm ước số chung lớn nhất (USCLN)
        private int USCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Hàm tìm bội số chung nhỏ nhất (USCNN)
        private int USCNN(int a, int b)
        {
            return (a * b) / USCLN(a, b);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            btntim.Text = "Tìm - USCLN";
        }

        private void groupbox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtketqua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
