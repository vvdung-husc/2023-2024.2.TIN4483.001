using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int TimUSCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
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
            if (chonUSCLN.Checked)
                {
                    int a = int.Parse(txtA.Text);
                    int b = int.Parse(txtB.Text);
                    int uscln = TimUSCLN(a, b);
                    txtKetQua.Text = uscln.ToString();
                }           
            else if (chonBSCNN.Checked)

            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                int bscnn = TimBSCNN(a, b);
                txtKetQua.Text = bscnn.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tìm USCLN hay BSCNN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void chonUSCLN_CheckedChanged(object sender, EventArgs e)
        {
            btnTim.Text = "Tìm - USCLN";
        }

        private void chonBSCNN_CheckedChanged(object sender, EventArgs e)
        {
            btnTim.Text = "Tìm - BSCNN";
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có chắc là muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtKetQua.Text = "";
        }
    }
}
