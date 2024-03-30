using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4_lab5_data_DataGridView
{

    public partial class Form1 : Form
    {

        protected List<Student> GetStudentByList()
        {
            List<Student> lStudent = new List<Student>();
            lStudent.Add(new Student("20T1020299", "Trần Lê Quốc Anh", "16/01/2002", "K44", "Công nghệ phần mềm"));
            lStudent.Add(new Student("18T1021014", "Trần Đình Quốc Bảo", "29/07/2000", "K42", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020009", "Nguyễn Ngọc Cầu", "02/01/2000", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020315", "Đặng Văn Chính", "05/03/2002", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020321", "Hoàng Văn Quốc Cường", "22/07/2002", "K44", "Công nghệ phần mềm"));
            lStudent.Add(new Student("20T1020331", "Lê Thị Diễm", "02/09/2002", "K44", "Công nghệ phần mềm"));
            lStudent.Add(new Student("20T1020022", "Lê Hữu Nhật Duy", "24/09/2002", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020343", "Hoàng Ngọc Quốc Dũng", "26/10/2002", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020356", "Bùi Văn Hoàng Hải", "10/10/2002", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("18T1021077", "Nguyễn Văn Hải", "24/01/2000", "K42", "Công nghệ phần mềm"));
            lStudent.Add(new Student("20T1020160", "Mai Thị Hiền", "27/09/2001", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020163", "Huỳnh Văn Hiếu", "29/10/2002", "K44", "Công nghệ phần mềm"));
            lStudent.Add(new Student("20T1020374", "Trương Hữu Hiếu", "28/01/2002", "K44", "Công nghệ phần mềm"));
            lStudent.Add(new Student("20T1020161", "Trần Xuân Hiển", "02/01/2002", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020386", "Phạm Nhật Huân", "28/03/2002", "K44", "Công nghệ phần mềm"));
            lStudent.Add(new Student("20T1020398", "Lê Viết Gia Huy", "03/01/2002", "K44", "Công nghệ phần mềm"));
            lStudent.Add(new Student("20T1020389", "Trần Quốc Hùng", "16/05/2002", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020175", "Trương Minh Hùng", "11/05/2001", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020052", "Trần Viết Huy Khang", "27/11/2002", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020417", "Lê Quang Khánh", "31/03/2002", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020054", "Ngô Gia Khánh", "17/09/2002", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020447", "Lê Gia Lộc", "11/02/2001", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020072", "Hồ Văn Khánh Nguyên", "16/04/2002", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020218", "Nguyễn Cửu Hiếu Nhân", "05/06/1999", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020486", "Trần Đỗ Thiện Nhân", "18/06/2002", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020496", "Nguyễn Văn Hoàng Nhật", "04/06/2002", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020087", "Nguyễn Ngọc Quyền", "14/04/2002", "K44", "Công nghệ phần mềm"));
            lStudent.Add(new Student("19T1021217", "Nguyễn Đức Sinh", "06/05/2001", "K43", "Công nghệ phần mềm"));
            lStudent.Add(new Student("20T1020539", "Quách Phạm Thiện Sơn", "07/10/2002", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020546", "Nguyễn Phúc Tài", "06/10/2002", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020092", "Trần Nhật Tân", "05/12/2001", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020555", "Nguyễn Nhật Thành", "16/04/2002", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020098", "Trần Huy Thành", "17/09/2002", "K44", "Công nghệ phần mềm"));
            lStudent.Add(new Student("20T1020106", "Dư An Thịnh", "13/03/2002", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020107", "Lê Gia Bảo Thịnh", "21/12/2002", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020574", "Trần Văn Thống", "27/10/2002", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020582", "Nguyễn Hoàng Mỹ Tiên", "17/10/2002", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020583", "Nguyễn Thị Thảo Tiên", "02/02/2002", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("19T1021283", "Lê Nữ Diệu Trinh", "02/12/2000", "K44", "Mạng máy tính"));
            lStudent.Add(new Student("20T1020612", "Phạm Nguyễn Bảo Trung", "23/05/2002", "K44", "Mạng máy tính"));

            return lStudent;
        }
        protected DataTable GetStudentByDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Mã sinh viên", typeof(string));
            table.Columns.Add("Họ và tên", typeof(string));
            table.Columns.Add("Ngày sinh", typeof(string));
            table.Columns.Add("Khóa học", typeof(string));
            table.Columns.Add("Ngành học", typeof(string));

            table.Rows.Add("20T1020299", "Trần Lê Quốc Anh", "16/01/2002", "K44", "Công nghệ phần mềm");
            table.Rows.Add("18T1021014", "Trần Đình Quốc Bảo", "29/07/2000", "K42", "Mạng máy tính");
            table.Rows.Add("20T1020009", "Nguyễn Ngọc Cầu", "02/01/2000", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020315", "Đặng Văn Chính", "05/03/2002", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020321", "Hoàng Văn Quốc Cường", "22/07/2002", "K44", "Công nghệ phần mềm");
            table.Rows.Add("20T1020331", "Lê Thị Diễm", "02/09/2002", "K44", "Công nghệ phần mềm");
            table.Rows.Add("20T1020022", "Lê Hữu Nhật Duy", "24/09/2002", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020343", "Hoàng Ngọc Quốc Dũng", "26/10/2002", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020356", "Bùi Văn Hoàng Hải", "10/10/2002", "K44", "Mạng máy tính");
            table.Rows.Add("18T1021077", "Nguyễn Văn Hải", "24/01/2000", "K42", "Công nghệ phần mềm");
            table.Rows.Add("20T1020160", "Mai Thị Hiền", "27/09/2001", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020163", "Huỳnh Văn Hiếu", "29/10/2002", "K44", "Công nghệ phần mềm");
            table.Rows.Add("20T1020374", "Trương Hữu Hiếu", "28/01/2002", "K44", "Công nghệ phần mềm");
            table.Rows.Add("20T1020161", "Trần Xuân Hiển", "02/01/2002", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020386", "Phạm Nhật Huân", "28/03/2002", "K44", "Công nghệ phần mềm");
            table.Rows.Add("20T1020398", "Lê Viết Gia Huy", "03/01/2002", "K44", "Công nghệ phần mềm");
            table.Rows.Add("20T1020389", "Trần Quốc Hùng", "16/05/2002", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020175", "Trương Minh Hùng", "11/05/2001", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020052", "Trần Viết Huy Khang", "27/11/2002", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020417", "Lê Quang Khánh", "31/03/2002", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020054", "Ngô Gia Khánh", "17/09/2002", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020447", "Lê Gia Lộc", "11/02/2001", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020072", "Hồ Văn Khánh Nguyên", "16/04/2002", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020218", "Nguyễn Cửu Hiếu Nhân", "05/06/1999", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020486", "Trần Đỗ Thiện Nhân", "18/06/2002", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020496", "Nguyễn Văn Hoàng Nhật", "04/06/2002", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020087", "Nguyễn Ngọc Quyền", "14/04/2002", "K44", "Công nghệ phần mềm");
            table.Rows.Add("19T1021217", "Nguyễn Đức Sinh", "06/05/2001", "K43", "Công nghệ phần mềm");
            table.Rows.Add("20T1020539", "Quách Phạm Thiện Sơn", "07/10/2002", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020546", "Nguyễn Phúc Tài", "06/10/2002", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020092", "Trần Nhật Tân", "05/12/2001", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020555", "Nguyễn Nhật Thành", "16/04/2002", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020098", "Trần Huy Thành", "17/09/2002", "K44", "Công nghệ phần mềm");
            table.Rows.Add("20T1020106", "Dư An Thịnh", "13/03/2002", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020107", "Lê Gia Bảo Thịnh", "21/12/2002", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020574", "Trần Văn Thống", "27/10/2002", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020582", "Nguyễn Hoàng Mỹ Tiên", "17/10/2002", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020583", "Nguyễn Thị Thảo Tiên", "02/02/2002", "K44", "Mạng máy tính");
            table.Rows.Add("19T1021283", "Lê Nữ Diệu Trinh", "02/12/2000", "K44", "Mạng máy tính");
            table.Rows.Add("20T1020612", "Phạm Nguyễn Bảo Trung", "23/05/2002", "K44", "Mạng máy tính");

            return table;
        }

        public Form1()
        {
            InitializeComponent();

            //dgvMember.DataSource = GetStudentByList();
            //dgvMember.DataSource = GetStudentByDataTable();
        }

        private void radList_CheckedChanged(object sender, EventArgs e)
        {
            dgvMember.DataSource = GetStudentByList();
        }

        private void radDataTable_CheckedChanged(object sender, EventArgs e)
        {
            dgvMember.DataSource = GetStudentByDataTable();
        }

        private void dgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
