using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkUSCLN_CheckedChanged(object sender, EventArgs e)
        {
            btnFind.Text = "Tìm - USCLN";
        }

        private void chkBSCNN_CheckedChanged(object sender, EventArgs e)
        {
            btnFind.Text = "Tìm - BSCNN";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtNumA.Text = "";
            txtNumB.Text = "";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string num_a = txtNumA.Text;
            string num_b = txtNumB.Text;
            int a = int.Parse(num_a.Length > 0 ? num_a : "0");
            int b = int.Parse(num_b.Length > 0 ? num_b : "0");
            if (chkUSCLN.Checked)
            {
                int uscln = TimUSCLN(a, b);
                MessageBox.Show("Đang chọn USCLN => Tính kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtResult.Text = uscln.ToString();
            }
            else if (chkBSCNN.Checked)
            {
                int bscnn = TimBSCNN(a, b);
                MessageBox.Show("Đang chọn BSCNN => Tính kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtResult.Text = bscnn.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tìm USCLN hay BSCNN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int TimBSCNN(int a, int b)
        {
            int max = Math.Max(a, b);
            while (true)
            {
                if (max % a == 0 && max % b == 0)
                {
                    return max;
                }
                max++;
            }
        }

        private int TimUSCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
