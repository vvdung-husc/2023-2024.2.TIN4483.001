using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppThree;

namespace WindowAppThree
{
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
        public Student(string id, string name, string birddate, string course, string subject)
        {
            this.msv = id;
            this.ten = name;
            this.ngaysinh = birddate;
            this.khoahoc = course;
            this.nganhhoc = subject;
        }
    }


}