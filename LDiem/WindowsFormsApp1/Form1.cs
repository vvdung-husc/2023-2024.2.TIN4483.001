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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
            tb2.Text = "";
            tbKQ.Text = "";
            tb1.Focus();
        }

        private int a;
        private int b;

        string  Uocchung()
        {
            string KQ = "";
            for(int i = 1; i < a; i++)
            {
                if(a%i==0 && b % i == 0)
                {
                    KQ = KQ + ("," + i.ToString());
                }
            }
            return KQ;
        }

        int UCLN()
        {
            if (a == 0 || b == 0)
            {
                return a + b;
            }
            while (a!=b){
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            a=int.Parse(tb1.Text);
            b=int.Parse(tb2.Text);
            string tan = "";
            int tan1 = 0;
            if(rbt1.Checked)
            {
                tan = Uocchung();
                tbKQ.Text = tan.ToString();
            }
            else {
                tan1 = UCLN();
                tbKQ.Text = tan1.ToString();
            }
        }
    }
}
