using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowAppOne
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

        private void btnPlus_Click_1(object sender, EventArgs e)
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
            /*string num_n = txtNumN.Text;
             string num_m = txtNumM.Text;
              int n = int.Parse(num_n.Length > 0 ? num_n : "0");
              int m = int.Parse(num_m.Length > 0 ? num_m : "0");

             int quotient = n / m;
             int remainder = n % m;
             txtResult.Text = quotient.ToString();
             txtResult1.Text = remainder.ToString();*/
            String num_n = txtNumN.Text;
            String num_m = txtNumM.Text;
            float n = float.Parse(num_n.Length > 0 ? num_n : "0");
            float m = float.Parse(num_m.Length > 0 ? num_m : "0");
            if
               (float.Parse(txtNumM.Text) == 0)
            {
                MessageBox.Show("Nhập lại số m", "Thông báo");
            }
            // int n = int.Parse(txtSon.Text);
            // int m = int.Parse(txtSom.Text);
            else
            {
                float Chia = n / m;
                txtResult.Text = Chia.ToString();
            }

            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

