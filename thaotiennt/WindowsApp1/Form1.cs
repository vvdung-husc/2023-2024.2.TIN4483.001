using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            string so_n = txtSon.Text;
            string so_m = txtSom.Text;
            int n = int.Parse(so_n.Length > 0 ? so_n : "0");
            int m = int.Parse(so_m.Length > 0 ? so_m : "0");
            int tong = n + m;
            txtKQ.Text = tong.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            string so_n = txtSon.Text;
            string so_m = txtSom.Text;
            int n = int.Parse(so_n.Length > 0 ? so_n : "0");
            int m = int.Parse(so_m.Length > 0 ? so_m : "0");
            int hieu = n - m;
            txtKQ.Text = hieu.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            string so_n = txtSon.Text;
            string so_m = txtSom.Text;
            int n = int.Parse(so_n.Length > 0 ? so_n : "0");
            int m = int.Parse(so_m.Length > 0 ? so_m : "0");
            int tich = n * m;
            txtKQ.Text = tich.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            string so_n = txtSon.Text;
            string so_m = txtSom.Text;
            int n = int.Parse(so_n.Length > 0 ? so_n : "0");
            int m = int.Parse(so_m.Length > 0 ? so_m : "0");
            int thuong = n / m;
            txtKQ.Text = thuong.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSon.Text = "";
            txtSom.Text = "";
            txtKQ.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Calculator", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
