using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_UocBoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Thoát Ứng dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void groupKetqua_Enter(object sender, EventArgs e)
        {

        }

  

        private void btboqua_Click(object sender, EventArgs e)
        {
            txta.Text = "";
            txtb.Text = "";
        }
       
        private void chkBSCNN_CheckedChanged(object sender, EventArgs e)
        {
            bttim.Text = "Tìm - BSCNN";
        }

        private void chkUSCLN_CheckedChanged(object sender, EventArgs e)
        {
            bttim.Text = "Tìm - USCLN";
           
        }

        private void bttim_Click(object sender, EventArgs e)
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
            if (!int.TryParse(txta.Text, out a) || !int.TryParse(txtb.Text, out b))
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

            txtkq.Text = "" + result;
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

        private void txta_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

    

