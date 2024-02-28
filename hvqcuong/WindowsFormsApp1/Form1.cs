using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkUSLN_CheckedChanged(object sender, EventArgs e)
        {
            btnTim.Text = "Tìm - USCLN";
        }

        private void chkBSCNN_CheckedChanged(object sender, EventArgs e)
        {
            btnTim.Text = "Tìm - BSCNN";
        }
        private int TimUSCLN(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }

        private int TimBSCNN(int a, int b)
        {
            int uscln = TimUSCLN(a, b);
            int bscnn = (a * b) / uscln;
            return bscnn;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (chkUSCLN.Checked)
            {
                int a = int.Parse(txtsoa.Text);
                int b = int.Parse(txtsob.Text);
                int uscln = TimUSCLN(a, b);
                txtkq.Text = uscln.ToString();
            }
            else if (chkBSCNN.Checked)
            {
                int a = int.Parse(txtsoa.Text);
                int b = int.Parse(txtsob.Text);
                int bscnn = TimBSCNN(a, b);
                txtkq.Text = bscnn.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tìm USCLN hay BSCNN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
