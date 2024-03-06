using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Thoát Ứng dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Tim.Text = "Tìm-USCLN";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Tim.Text = "Tìm-BSCNN";
        }
        
        private int USLN(int SoA, int SoB)
        {
            if (SoB == 0) return SoA;
            return USLN(SoB, SoA % SoB);
        }
        private int BSNN(int SoA, int SoB)
        {
            return (SoA * SoB) / USLN(SoA, SoB);
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
           /* if (USCLN.Checked)
            {
                MessageBox.Show("Đang chọn USCLN => Tính kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (BSCNN.Checked)
            {
                MessageBox.Show("Đang chọn BSCNN => Tính kết quả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
           if (USCLN.Checked)
            {
                int m = SoA.Text.Length > 0 ? int.Parse(SoA.Text) : 0;
                int n = SoB.Text.Length > 0 ? int.Parse(SoB.Text) : 0;
                int uscln = USLN( m, n);
                ketqua.Text = uscln.ToString();

            }
           else if (BSCNN.Checked)
            {
                int m = SoA.Text.Length > 0 ? int.Parse(SoA.Text) : 0;
                int n = SoB.Text.Length > 0 ? int.Parse(SoB.Text) : 0;
                int bscnn = BSNN(m, n);
                ketqua.Text = bscnn.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tìm USCLN hay BSCNN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
                
            /** tim ươc so chung lon nhat
             */
            /* public int USCLN(int SoA, int SoB)
             {
                 if (SoB == 0) return SoA;
                 return USCLN(SoB, SoA % SoB);
             }

             /**
               Tim boi so chung nho nhat (BSCNN)
              /*
              public int BSCNN(int SoA, int SoB)
             {
                 return (SoA * SoB) / USCLN(SoA, SoB);
             }*/
           

        }
        private void button2_Click(object sender, EventArgs e)
        {
            SoA.Text = "";
            SoB.Text = "";
        }
    }
}
