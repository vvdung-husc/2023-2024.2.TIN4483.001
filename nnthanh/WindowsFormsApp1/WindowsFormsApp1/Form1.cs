using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApp1
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
            Tim.Text = "Tìm - USCLN";
        }

        private void chkBSCNN_CheckedChanged(object sender, EventArgs e)
        {
            Tim.Text = "Tìm - BSCNN";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            SoA.Text = "";
            SoB.Text = "";
        }

        private void Tim_Click_1(object sender, EventArgs e)
        {
            if (chkUSCLN.Checked)
            {
                MessageBox.Show("Đang chọn USCLN => Tính kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (chkBSCNN.Checked)
            {
                MessageBox.Show("Đang chọn BSCNN => Tính kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tìm USCLN hay BSCNN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
         }

            int USCLN(int a, int b)
            {
                if (b == 0) return a;
                return USCLN(b, a % b);
            }
            int BSCNN(int a, int b)
            {
                return (a * b) / USCLN(a, b);
            }
        
    }
}