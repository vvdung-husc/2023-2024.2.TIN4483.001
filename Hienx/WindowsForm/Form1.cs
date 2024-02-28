using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtson_Click(object sender, EventArgs e)
        {

        }

        private void btcong_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtson.Text);
            int m = int.Parse(txtsom.Text);
            int Tong = n + m;
            txtketqua.Text = Tong.ToString();
        }

        private void bttru_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtson.Text);
            int m = int.Parse(txtsom.Text);
            int Hieu = n - m;
            txtketqua.Text = Hieu.ToString();
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnhan_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtson.Text);
            int m = int.Parse(txtsom.Text);
            int Tich = n * m;
            txtketqua.Text = Tich.ToString();
        }

        private void btchia_Click(object sender, EventArgs e)
        {
            float n = float.Parse(txtson.Text);
            float m = float.Parse(txtsom.Text);
            if (m == 0)
            {
                MessageBox.Show("nhap so m khac 0");
            }
            else
            {
                float Thuong = n / m;
                txtketqua.Text = Thuong.ToString();
            }
        }
           

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Máy Tính", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            txtson.Text = "";
            txtsom.Text = "";
            txtketqua.Text = "";
        }
    }
}
