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

namespace WindowsForms2
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            gvOrrder.DataSource = tbOrder;

            //Định Dạng 2 Cột
            gvOrrder.Columns[0].Width = (int)(gvOrrder.Width * 0.4);
            gvOrrder.Columns[1].Width = (int)(gvOrrder.Width * 0.5);

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            tbOrder.Rows.Clear();
        }

        private void bbo_Click(object sender, EventArgs e)
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

        private void border_Click(object sender, EventArgs e)
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
                fileName = @"D:\Tranx\FileLog.txt";
            }

            // Lưu 
            if (!File.Exists(fileName))
            {
                streamWriter = new StreamWriter(fileName);
                // Cột Cột 1 10 ký tự 2 50 ký tự, cột 3 20 ký tự
                streamWriter.WriteLine(String.Format("{0,-10}", "Bàn")
                    + String.Format("{0,-50}", gvOrrder.Columns[0].HeaderText)
                    + String.Format("{0,-20}", gvOrrder.Columns[1].HeaderText));

                for (int i = 0; i < tbOrder.Rows.Count - 1; i++)
                {
                    // 
                    streamWriter.WriteLine(String.Format("{0,-10}", cbblist.SelectedItem.ToString())
                    + String.Format("{0,-50}", gvOrrder.Rows[i].Cells[0].Value)
                    + String.Format("{0,-20}", gvOrrder.Rows[i].Cells[1].Value));
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
                    + String.Format("{0,-50}", gvOrrder.Rows[i].Cells[0].Value)
                    + String.Format("{0,-20}", gvOrrder.Rows[i].Cells[1].Value));
                }
                streamWriter.Close();
            }
        }
    }

}