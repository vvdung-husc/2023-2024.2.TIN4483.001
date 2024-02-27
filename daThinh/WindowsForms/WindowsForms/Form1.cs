using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
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

        private void txtthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        private void txtcong_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtson.Text);
            int m = int.Parse(txtsom.Text);
            int Tong = n + m;
            txtketqua.Text = Tong.ToString();
        }

        private void txttru_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtson.Text);
            int m = int.Parse(txtsom.Text);
            int Hieu = n - m;
            txtketqua.Text = Hieu.ToString();
        }

        private void txtnhan_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtson.Text);
            int m = int.Parse(txtsom.Text);
            int Tich = n * m;
            txtketqua.Text = Tich.ToString();
        }

        private void txtchia_Click(object sender, EventArgs e)
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

        private void txtxoa_Click(object sender, EventArgs e)
        {
            txtson.Text = "";
            txtsom.Text = "";
            txtketqua.Text = "";
        }
    }
}
