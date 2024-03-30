using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EOrder
{
    public partial class Form1 : Form
    {
        private List<MyObject> myObjectList;

        public Form1()
        {
            InitializeComponent();
            myObjectList = new List<MyObject>();

            // Thêm dữ liệu vào danh sách
            myObjectList.Add(new MyObject { MaSV = "20T1020299", Ten = "Trần Lê Quốc Anh", NgaySinh = "16/01/2002", KhoaHoc = "K44", NganhHoc = "Công nghệ phần mềm" });
            myObjectList.Add(new MyObject { MaSV = "18T1021014", Ten = "Trần Đình Quốc Bảo", NgaySinh = "29/07/2000", KhoaHoc = "K42", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020009", Ten = "Nguyễn Ngọc Cầu", NgaySinh = "02/01/2000", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020315", Ten = "Đặng Văn Chính", NgaySinh = "05/03/2002", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020321", Ten = "Hoàng Văn Quốc Cường", NgaySinh = "22/07/2002", KhoaHoc = "K44", NganhHoc = "Công nghệ phần mềm" });
            myObjectList.Add(new MyObject { MaSV = "20T1020331", Ten = "Lê Thị Diễm", NgaySinh = "02/09/2002", KhoaHoc = "K44", NganhHoc = "Công nghệ phần mềm" });
            myObjectList.Add(new MyObject { MaSV = "20T1020022", Ten = "Lê Hữu Nhật Duy", NgaySinh = "24/09/2002", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020343", Ten = "Hoàng Trọng Quốc Dũng", NgaySinh = "26/10/2002", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020356", Ten = "Bùi Văn Hoàng Hải", NgaySinh = "10/10/2002", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "18T1021077", Ten = "Nguyễn Văn hải", NgaySinh = "24/01/2000", KhoaHoc = "K42", NganhHoc = "Công nghệ phần mềm" });
            myObjectList.Add(new MyObject { MaSV = "20T1020160", Ten = "Mai Thị Hiền", NgaySinh = "27/09/2001", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020163", Ten = "Huỳnh Văn Hiếu", NgaySinh = "29/10/2002", KhoaHoc = "K44", NganhHoc = "Công nghệ phần mềm" });
            myObjectList.Add(new MyObject { MaSV = "20T1020374", Ten = "Trương Hữu Hiếu", NgaySinh = "28/01/2002", KhoaHoc = "K44", NganhHoc = "Công nghệ phần mềm" });
            myObjectList.Add(new MyObject { MaSV = "20T1020161", Ten = "Trần Xuân Hiển", NgaySinh = "02/01/2002", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020386", Ten = "Phạm Nhật Huân", NgaySinh = "28/03/2002", KhoaHoc = "K44", NganhHoc = "Công nghệ phần mềm" });
            myObjectList.Add(new MyObject { MaSV = "20T1020398", Ten = "Lê Viết Gia Huy", NgaySinh = "03/01/2002", KhoaHoc = "K44", NganhHoc = "Công nghệ phần mềm" });
            myObjectList.Add(new MyObject { MaSV = "20T1020389", Ten = "Trần Quốc Hùng", NgaySinh = "16/05/2002", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020175", Ten = "Trương Minh Hùng", NgaySinh = "11/05/2001", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020052", Ten = "Trần Viết Huy Khang", NgaySinh = "27/11/2002", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020417", Ten = "Lê Quang Khánh", NgaySinh = "31/03/2002", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020054", Ten = "Ngô Gia Khánh", NgaySinh = "17/09/2002", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020447", Ten = "Lê Gia Lộc", NgaySinh = "11/02/2001", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020072", Ten = "Hồ Văn Khánh Nguyên", NgaySinh = "16/04/2002", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020218", Ten = "Nguyễn Cửu Hiếu Nhân", NgaySinh = "05/06/1999", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020486", Ten = "Trần Đỗ Thiện Nhân", NgaySinh = "18/06/2002", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020496", Ten = "Nguyễn Văn Hoàng Nhật", NgaySinh = "04/06/2002", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020087", Ten = "Nguyễn Ngọc Quyền", NgaySinh = "14/04/2002", KhoaHoc = "K44", NganhHoc = "Công nghệ phần mềm" });
            myObjectList.Add(new MyObject { MaSV = "19T1021217", Ten = "Nguyễn Đức Sinh", NgaySinh = "06/05/2001", KhoaHoc = "K43", NganhHoc = "Công nghệ phần mềm" });
            myObjectList.Add(new MyObject { MaSV = "20T1020539", Ten = "Quách Phạm Thiện Sơn", NgaySinh = "07/10/2002", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020546", Ten = "Nguyễn Phúc Tài", NgaySinh = "06/10/2002", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020092", Ten = "Trần Nhật Tân", NgaySinh = "05/12/2001", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020555", Ten = "Nguyễn Nhật Thành", NgaySinh = "16/04/2002", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020098", Ten = "Trần Huy Thành", NgaySinh = "17/09/2002", KhoaHoc = "K44", NganhHoc = "Công nghệ phần mềm" });
            myObjectList.Add(new MyObject { MaSV = "20T1020106", Ten = "Dư An Thịnh", NgaySinh = "13/03/2002", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020107", Ten = "Lê Gia Bảo Thịnh", NgaySinh = "21/12/2002", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020574", Ten = "Trần VĂn Thống", NgaySinh = "27/10/2002", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020582", Ten = "Nguyễn Hoàng Mỹ Tiên", NgaySinh = "17/10/2002", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020583", Ten = "Nguyễn Thị Thảo Tiên", NgaySinh = "02/02/2002", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "19T1021283", Ten = "Lê Nữ Diệu Trinh", NgaySinh = "02/12/2000", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
            myObjectList.Add(new MyObject { MaSV = "20T1020612", Ten = "Phạm Nguyễn Bảo Trung", NgaySinh = "23/05/2002", KhoaHoc = "K44", NganhHoc = "Mạng máy tính" });
           


            // Gán danh sách làm nguồn dữ liệu cho DataGridView
            dataGridView1.DataSource = myObjectList;
        }
    }

    public class MyObject
    {
        public string MaSV { get; set; } = "";
        public string Ten { get; set; } = "";
        public string NgaySinh { get; set; } = "";
        public string KhoaHoc { get; set; } = "";
        public string NganhHoc { get; set; } = "";


        // Các thuộc tính khác của đối tượng
    }
}