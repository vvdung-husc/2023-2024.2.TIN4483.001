using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        private List<MyObject> myObjectList;

        public Form1()
        {
            InitializeComponent();
            myObjectList = new List<MyObject>
            {
                // Thêm dữ liệu vào danh sách
                new MyObject { FoodName = "Gà viên cola", Quantity = 1 },
                new MyObject { FoodName = "Gà rán phần", Quantity = 1 },
                new MyObject { FoodName = "Burger Phô mai", Quantity = 2 },
                new MyObject { FoodName = "Lipton", Quantity = 2 },
                new MyObject { FoodName = "Pepsi", Quantity = 1 },
                new MyObject { FoodName = "7 up", Quantity = 1 }
            };

            // Gán danh sách làm nguồn dữ liệu cho DataGridView
            dataGridView1.DataSource = myObjectList;
        }
    }

    public class MyObject
    {
        public string FoodName { get; set; } = "";
        public int Quantity { get; set; }
        // Các thuộc tính khác của đối tượng
    }
}