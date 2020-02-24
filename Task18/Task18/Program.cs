using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> lst = new List<Student>
            {
                new Student{Sid = 1002,Sname="Rohit",Course = "Physics"},
                new Student{Sid = 1001,Sname ="Sarvanan",Course = "Maths"},
                new Student{Sid = 1003,Sname = "Vinod",Course = "Biology"},
                new Student{Sid = 1004,Sname = "Mohinder",Course = "Arts"}
            };

            Program obj = new Program();
            List<Student> lstout = obj.ListDemo(lst);

            foreach (Student s in lstout)
            {
                Console.WriteLine("{0}\n{1}\n{2}", s.Sid, s.Sname, s.Course);
            }

        }

        public List<Student> ListDemo(List<Student> lst)
        {
            var s = from a in lst orderby a.Sid select a;
            return s.ToList();
        }
    }
}
