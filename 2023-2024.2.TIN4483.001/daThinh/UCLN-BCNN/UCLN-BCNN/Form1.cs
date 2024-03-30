using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCLN_BCNN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void USCLN_CheckedChanged(object sender, EventArgs e)
        {
            btntim.Text = "Tìm - USCLN";
        }

        private void BSCNN_CheckedChanged(object sender, EventArgs e)
        {
            btntim.Text = "Tìm - BSCNN";
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

        private void btntim_Click(object sender, EventArgs e)
        {
            if (USCLN.Checked)
            {
                int a = int.Parse(txtsoa.Text);
                int b = int.Parse(txtsob.Text);
                int uscln = TimUSCLN(a, b);
                txtketqua.Text = uscln.ToString();
            }
            else if (BSCNN.Checked)
            {
                int a = int.Parse(txtsoa.Text);
                int b = int.Parse(txtsob.Text);
                int bscnn = TimBSCNN(a, b);
                txtketqua.Text = bscnn.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tìm USCLN hay BSCNN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtsoa.Text = "";
            txtsob.Text = "";
            txtketqua.Text = "";
        }
    }
}
