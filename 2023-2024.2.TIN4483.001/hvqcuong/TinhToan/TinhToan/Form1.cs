using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhToan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int soa = Convert.ToInt32(txtsoa.Text);
            int sob = Convert.ToInt32(txtsob.Text);
            int Kq = soa - sob;
            txtketqua.Text = Kq.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtsob_TextChanged(object sender, EventArgs e)
        {

        }

        private void btcong_Click(object sender, EventArgs e)
        {
            int soa = Convert.ToInt32(txtsoa.Text);
            int sob = Convert.ToInt32(txtsob.Text);
            int Kq = soa + sob;
            txtketqua.Text = Kq.ToString();
        }

        private void btnhan_Click(object sender, EventArgs e)
        {
            int soa = Convert.ToInt32(txtsoa.Text);
            int sob = Convert.ToInt32(txtsob.Text);
            int Kq = soa * sob;
            txtketqua.Text = Kq.ToString();
        }

        private void btchia_Click_1(object sender, EventArgs e)
        {
            float soa = float.Parse(txtsoa.Text);
            float sob = float.Parse(txtsob.Text);
            if (sob == 0)
            {
                MessageBox.Show("nhap so b khac 0");
            }
            else
            {
                float chia = soa / sob;
                txtketqua.Text = chia.ToString();
            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }
    }
}
