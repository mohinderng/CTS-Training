using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertData();
        }

        public static void InsertData()
        {
            ExamStudentContainer esc = new ExamStudentContainer();
            var exams = new List<Exam>
            {
                new Exam{Ename = "English",TotalMarks = 100, Date = Convert.ToDateTime("2020-02-18") },
                new Exam{Ename = "Math", TotalMarks = 100, Date = Convert.ToDateTime("2020-02-19")},
                new Exam{Ename = "Physics", TotalMarks = 100,Date = Convert.ToDateTime("2020-02-20")},
                new Exam{Ename = "Chemistry", TotalMarks = 100,Date = Convert.ToDateTime("2020-02-21")},
                new Exam{Ename = "Hindi", TotalMarks = 100, Date = Convert.ToDateTime("2020-02-22")}
            };
            exams.ForEach(e => esc.Exams.Add(e));
            esc.SaveChanges();

            var students = new List<Student>
            {
                new Student{Sname ="Mohit"},
                new Student{Sname="Rohit"},
                new Student{Sname = "Shobhit"}
            };
            students.ForEach(s => esc.Students.Add(s));
            esc.SaveChanges();
        }
    }
}
