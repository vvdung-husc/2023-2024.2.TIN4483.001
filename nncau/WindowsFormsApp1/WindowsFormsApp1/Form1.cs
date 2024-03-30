using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtm.Text = "";
            txtn.Text = "";
            txtKetqua.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String num_n = txtm.Text;
            String num_m = txtn.Text;
            int n = int.Parse(num_n.Length > 0 ? num_n : "0");
            int m = int.Parse(num_m.Length > 0 ? num_m : "0");
            // int n = int.Parse(txtSon.Text);
            // int m = int.Parse(txtSom.Text);
            int Tong = n + m;
            txtKetqua.Text = Tong.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtm.Text = "";
            txtn.Text = "";
            txtKetqua.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Thoát Ứng dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

 
    }
}
