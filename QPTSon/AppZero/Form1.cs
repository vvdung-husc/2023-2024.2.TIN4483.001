using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppZero
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            string num_n = txtNumN.Text;
            string num_m = txtNumM.Text;
            int n = int.Parse(num_n.Length > 0 ? num_n : "0");
            int m = int.Parse(num_m.Length > 0 ? num_m : "0");
            int sum = n + m;
            txtResult.Text = sum.ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            string num_n = txtNumN.Text;
            string num_m = txtNumM.Text;
            int n = int.Parse(num_n.Length > 0 ? num_n : "0");
            int m = int.Parse(num_m.Length > 0 ? num_m : "0");
            int difference = n - m;
            txtResult.Text = difference.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            string num_n = txtNumN.Text;
            string num_m = txtNumM.Text;
            int n = int.Parse(num_n.Length > 0 ? num_n : "0");
            int m = int.Parse(num_m.Length > 0 ? num_m : "0");
            int product = n * m;
            txtResult.Text = product.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            float NumN = float.Parse(txtNumN.Text);
            float NumM = float.Parse(txtNumM.Text);
            if (NumM == 0)
            {
                MessageBox.Show("nhap so M  khac 0");
            }
            else
            {
                float chia = NumN / NumM;
                txtResult.Text = chia.ToString();
            }
        }

    }
}




