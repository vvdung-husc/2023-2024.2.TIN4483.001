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

      

        private void button6_Click(object sender, EventArgs e)
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

        private void btCong_Click(object sender, EventArgs e)
        {
            String num_n = txtSon.Text;
            String num_m = txtSom.Text;
            int n = int.Parse(num_n.Length > 0 ? num_n : "0");
            int m = int.Parse(num_m.Length > 0 ? num_m : "0");
           // int n = int.Parse(txtSon.Text);
           // int m = int.Parse(txtSom.Text);
            int Tong = n + m;
            txtKetqua.Text = Tong.ToString();

        }

        private void btTru_Click(object sender, EventArgs e)
        {
            String num_n = txtSon.Text;
            String num_m = txtSom.Text;
            int n = int.Parse(num_n.Length > 0 ? num_n : "0");
            int m = int.Parse(num_m.Length > 0 ? num_m : "0");
            // int n = int.Parse(txtSon.Text);
            // int m = int.Parse(txtSom.Text);
            int Hieu = n - m;
            txtKetqua.Text = Hieu.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            String num_n = txtSon.Text;
            String num_m = txtSom.Text;
            int n = int.Parse(num_n.Length > 0 ? num_n : "0");
            int m = int.Parse(num_m.Length > 0 ? num_m : "0");
            // int n = int.Parse(txtSon.Text);
            // int m = int.Parse(txtSom.Text);
            int Nhan = n * m;
            txtKetqua.Text = Nhan.ToString();
        }
    }
}
