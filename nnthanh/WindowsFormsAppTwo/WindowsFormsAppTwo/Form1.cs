using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTwo
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

        /*private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }*/
        private void chkUSCLN_CheckedChanged(object sender, EventArgs e)
        {
            btnFind.Text = "Tìm - USCLN";
        }

        private void chkBSCNN_CheckedChanged(object sender, EventArgs e)
        {
            btnFind.Text = "Tìm - BSCNN";
        }
        private void btnDel_Click_1(object sender, EventArgs e)
        {
            txtNumA.Text = "";
            txtNumB.Text = "";
        }
        /* private void btnDel_Click(object sender, EventArgs e)
         {
             txtNumA.Text = "";
             txtNumB.Text = "";
         }*/

        private void btnFind_Click(object sender, EventArgs e)
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

            int A, B;
            if (!int.TryParse(txtNumA.Text, out A) || !int.TryParse(txtNumB.Text, out B))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ.");
                return;
            }

            int Result;
            if (chkUSCLN.Checked)
            {
                Result = USCLN(A, B);
            }
            else
            {
                Result = USCNN(A, B);
            }

            txtResult.Text = "" + Result;
        }
        // Hàm tìm ước số chung lớn nhất (USCLN)
        private int USCLN(int A, int B)
        {
            while (B != 0)
            {
                int temp = B;
                B = A % B;
                A = temp;
            }
            return A;
        }

        // Hàm tìm bội số chung nhỏ nhất (USCNN)
        private int USCNN(int A, int B)
        {
            return (A * B) / USCLN(A, B);
        }


    }
}