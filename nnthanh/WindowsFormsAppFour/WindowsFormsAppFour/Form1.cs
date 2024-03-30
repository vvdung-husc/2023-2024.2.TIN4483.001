using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsAppFour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void GetPay()
        {
            string customerName = txtname.Text.Trim();

            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double total = 0;

            if (chkcaovoi.Checked)
                total += 100000;

            if (chktaytrang.Checked)
                total += 1200000;

            if (chkchuphinhrang.Checked)
                total += 200000;

            int soRangTram;
            if (int.TryParse(txtsorangtram.Text, out soRangTram))
            {
                total += soRangTram * 80000;
            }


            txtTotal.Text = total.ToString("C");
        }

   

      

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btTinhTien_Click_1(object sender, EventArgs e)
        {
            GetPay();
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
