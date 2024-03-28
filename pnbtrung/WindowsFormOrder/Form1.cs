using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormOrder
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow row;
            bool co = true;
            Button b = (Button)sender;
            // Tạo Mới 1 dòng vào DataTable
            row = tbOrder.NewRow();

            foreach (DataRow item in tbOrder.Rows) // Duyệt Từng dòng trong datatable 
            {
                if (item[0].ToString() == b.Text)
                {
                    co = false;
                    // Tăng Số Lượng
                    item[1] = int.Parse(item[1].ToString()) + 1;
                    break;
                }
            }

            if (co)
            {
                // Gán Giá Trị Cho Dòng Mới
                row[0] = b.Text;
                row[1] = 1;

                // Add vào DataTable
                tbOrder.Rows.Add(row);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tbOrder.Rows.Clear();
        }
    }
}
