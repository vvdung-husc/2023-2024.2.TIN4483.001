using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        #region Biến Toàn Cục
        string[] Ban = new string[] { "Ban1", "Ban2", "Ban3", "Ban4" };
        DataTable tbOrder;
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            cbblist.Items.AddRange(Ban);
            
            tbOrder = new DataTable();  
            // Table có 2 cột
            tbOrder.Columns.Add("FoodName");
            tbOrder.Columns.Add("Quantity");

            //Add table Vào DataGridView
            gvOrder.DataSource = tbOrder;

            //Định Dạng 2 Cột
            gvOrder.Columns[0].Width = (int)(gvOrder.Width * 0.4);
            gvOrder.Columns[1].Width = (int)(gvOrder.Width * 0.5);
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
                if (item[0].ToString()==b.Text)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(cbblist.SelectedIndex.ToString());
        }

        

        private void btnorder_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter;
            SaveFileDialog saveFileDialog;
            string fileName = "";
            // Ghi ra file text
            // 1. Chọn file Lưu
            saveFileDialog = new SaveFileDialog();
            // 2. Có thì lưu trên file đó
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
            }
            // 3. Không chọn, thì lưu trên file mặc định
            else
            {
                fileName = @"D:\C#\FileLog.txt";
            }

            // Lưu 
            if (!File.Exists(fileName))
            {
                streamWriter = new StreamWriter(fileName);
                // Cột Cột 1 10 ký tự 2 50 ký tự, cột 3 20 ký tự
                streamWriter.WriteLine(String.Format("{0,-10}", "Bàn")
                    + String.Format("{0,-50}", gvOrder.Columns[0].HeaderText)
                    + String.Format("{0,-20}", gvOrder.Columns[1].HeaderText));

                for (int i = 0; i < tbOrder.Rows.Count - 1; i++)
                {
                    // 
                    streamWriter.WriteLine(String.Format("{0,-10}", cbblist.SelectedItem.ToString())
                    + String.Format("{0,-50}", gvOrder.Rows[i].Cells[0].Value)
                    + String.Format("{0,-20}", gvOrder.Rows[i].Cells[1].Value));
                }
                streamWriter.Close();
            }
            else
            {
                streamWriter = File.AppendText(fileName);
                for (int i = 0; i < tbOrder.Rows.Count - 1; i++)
                {
                    // 
                    streamWriter.WriteLine(String.Format("{0,-10}", cbblist.SelectedItem.ToString())
                    + String.Format("{0,-50}", gvOrder.Rows[i].Cells[0].Value)
                    + String.Format("{0,-20}", gvOrder.Rows[i].Cells[1].Value));
                }
                streamWriter.Close();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            tbOrder.Rows.Clear();
        }

        private void gvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
