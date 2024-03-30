using System;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtKetqua.Text = "";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            
            if (checkUscln.Checked)
            {

                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                int uscln = TimUSCLN(a, b);
                txtKetqua.Text = uscln.ToString();
            }
            else if (checkBscnn.Checked) 
            {
                int a = int.Parse(txtA.Text);
                int b = int.Parse(txtB.Text);
                int bscnn = TimBSCNN(a, b);
                txtKetqua.Text = bscnn.ToString();
            }    
            else
            {
                MessageBox.Show("Vui lòng chọn option", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void checkUscln_CheckedChanged(object sender, EventArgs e)
        {
            btnTim.Text = "Tìm USCLN";
        }

        private void checkBscnn_CheckedChanged(object sender, EventArgs e)
        {
            btnTim.Text = "Tìm BSCNN";
        }

        private void txtKetqua_Click(object sender, EventArgs e)
        {

        }
    }
}
