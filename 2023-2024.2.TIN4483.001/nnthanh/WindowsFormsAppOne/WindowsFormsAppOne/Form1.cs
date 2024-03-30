﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppOne
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        private void btThoat_Click(object sender, EventArgs e)
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

        private void btCong_Click(object sender, EventArgs e)
        {
            string num_n = txtSon.Text;
            string num_m = txtSom.Text;
            int n = int.Parse(num_n.Length > 0 ? num_n : "0");
            int m = int.Parse(num_m.Length > 0 ? num_m : "0");
            int sum = n + m;
            txtKetqua.Text = sum.ToString();
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            string num_n = txtSon.Text;
            string num_m = txtSom.Text;
            int n = int.Parse(num_n.Length > 0 ? num_n : "0");
            int m = int.Parse(num_m.Length > 0 ? num_m : "0");
            int sum = n - m;
            txtKetqua.Text = sum.ToString();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            string num_n = txtSon.Text;
            string num_m = txtSom.Text;
            int n = int.Parse(num_n.Length > 0 ? num_n : "0");
            int m = int.Parse(num_m.Length > 0 ? num_m : "0");
            int sum = n * m;
            txtKetqua.Text = sum.ToString();
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            
        }
    }
       
}
