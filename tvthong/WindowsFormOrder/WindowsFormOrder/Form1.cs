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
        private DataTable tbOrder = new DataTable();
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbOrder.Columns.Add("FoodName");
            tbOrder.Columns.Add("Quantity");

        }
    }
}
