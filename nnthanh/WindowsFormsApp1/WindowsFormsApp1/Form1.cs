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

            int a, b;
            if (!int.TryParse(SoA.Text, out a) || !int.TryParse(SoB.Text, out b))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ.");
                return;
            }

            int result;
            if (chkUSCLN.Checked)
            {
                result = USCLN(a, b);
            }
            else
            {
                result = USCNN(a, b);
            }

            Ketqua.Text = "" + result;
        }


        // Hàm tìm USCLN
        private int USCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

     // hàm tìm BSCNN
        private int USCNN(int a, int b)
        {
            return (a * b) / USCLN(a, b);
        }


    }

        
    }