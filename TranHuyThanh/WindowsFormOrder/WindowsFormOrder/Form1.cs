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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        string[] Ban = new string[] { "Ban1", "Ban2", "Ban3", "Ban4" };
        DataTable tbOrder;
        private void Form1_Load(object sender, EventArgs e)
        {
            cbblist.Items.AddRange(Ban);

            tbOrder = new DataTable();
            // Table có 2 cột
            tbOrder.Columns.Add("FoodName");
            tbOrder.Columns.Add("Quantity");

            //Add table Vào DataGridView
            dataGridView1.DataSource = tbOrder;


            //Định Dạng 2 Cột
            dataGridView1.Columns[0].Width = (int)(dataGridView1.Width * 0.4);
            dataGridView1.Columns[1].Width = (int)(dataGridView1.Width * 0.5);
        }

        private void bpmbo_Click(object sender, EventArgs e)
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

        private void button16_Click(object sender, EventArgs e)
        {
            tbOrder.Rows.Clear();
        }
    }
}
