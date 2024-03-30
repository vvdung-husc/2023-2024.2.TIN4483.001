﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAppTwo
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

        private void chkUSCLN_CheckedChanged(object sender, EventArgs e)
        {
            btnFind.Text = "Tìm - USCLN";
        }

        private void chkBSCNN_CheckedChanged(object sender, EventArgs e)
        {
            btnFind.Text = "Tìm - BSCNN";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtNumA.Text = "";
            txtNumB.Text = "";
            txtResult.Text = "";
        }

        /**
 * Tim uoc so chung lon nhat (USCLN)
 */
        private int USCLN(int a, int b)
        {
            if (b == 0) return a;
            return USCLN(b, a % b);
        }

        /**
         * Tim boi so chung nho nhat (BSCNN)
         */
        private int BSCNN(int a, int b)
        {
            return (a * b) / USCLN(a, b);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (chkUSCLN.Checked)
            {
                //MessageBox.Show("Đang chọn USCLN => Tính kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int a = txtNumA.Text.Length > 0 ? Int32.Parse(txtNumA.Text) : 0;
                int b = txtNumA.Text.Length > 0 ? Int32.Parse(txtNumB.Text) : 0;
                int c = USCLN(a, b);
                txtResult.Text = c.ToString();
            }
            else if (chkBSCNN.Checked)
            {
                //MessageBox.Show("Đang chọn BSCNN => Tính kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int a = txtNumA.Text.Length > 0 ? Int32.Parse(txtNumA.Text) : 0;
                int b = txtNumA.Text.Length > 0 ? Int32.Parse(txtNumB.Text) : 0;
                int c = BSCNN(a, b);
                txtResult.Text = c.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tìm USCLN hay BSCNN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
