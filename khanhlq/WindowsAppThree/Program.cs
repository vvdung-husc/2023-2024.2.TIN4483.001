using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAppThree
{
    public class Student
    {
        public string msv { get; set; }
        public string ten { get; set; }
        public string ngaysinh { get; set; }
        public string khoahoc { get; set; }
        public string nganhhoc { get; set; }
        public Student(string id, string ten, string ngay, string khoa, string nganh)
        {
            this.msv = id;
            this.ten = ten;
            this.ngaysinh = ngay;
            this.khoahoc = khoa;
            this.nganhhoc = nganh;
        }
    }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public class Student
    {
        public string msv { get; set; }
        public string ten { get; set; }
        public string ngaysinh { get; set; }
        public string khoahoc { get; set; }
        public string nganhhoc { get; set; }
        public Student(string id, string name, string ngay, string khoa, string nganh)
        {
            this.msv = id;
            this.ten = name;
            this.ngaysinh = ngay;
            this.khoahoc = khoa;
            this.nganhhoc = nganh;
        }
    }
}
