using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnthoat(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btncong(object sender, EventArgs e)
        {
            string num_n = txtNumN.Text;
            string num_m = txtNumM.Text;
            int n = int.Parse(num_n.Length > 0 ? num_n : "0");
            int m = int.Parse(num_m.Length > 0 ? num_m : "0");
            int sum = n + m;
            txtResult.Text = sum.ToString();
        }

        private void btnnhan(object sender, EventArgs e)
        {

        }

        private void btnchia(object sender, EventArgs e)
        {

        }

        private void btnxoa(object sender, EventArgs e)
        {

        }

        private void NumN(object sender, EventArgs e)
        {

        }

    }
}