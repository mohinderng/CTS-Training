using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertData();
            ShowData();
        }

        public static void InsertData()
        {
            ExamStudentContainer esc = new ExamStudentContainer();
            /*var exams = new List<Exam>
            {
                new Exam{Ename ="English",TotalMarks=100,Date = Convert.ToDateTime("2020-02-18")},
                new Exam{Ename ="Math",TotalMarks=100,Date = Convert.ToDateTime("2020-02-19")},
                new Exam{Ename ="Physics",TotalMarks=100,Date = Convert.ToDateTime("2020-02-20")},
                new Exam{Ename ="Chemistry",TotalMarks=100,Date = Convert.ToDateTime("2020-02-21")},
                new Exam{Ename="Hindi",TotalMarks=100,Date = Convert.ToDateTime("2020-02-22")}
            };

            exams.ForEach(e => esc.Exams.Add(e));
            esc.SaveChanges();

            var students = new List<Student>
            {
                new Student{Sname="Mohit"},
                new Student{Sname="Rohit"},
            };
            students.ForEach(s => esc.Students.Add(s));
            esc.SaveChanges();
            
            var results = new List<Result>
            {
             new Result{StudentSid = 1,ExamEid = 1, Score = 85 },
             new Result{StudentSid = 1,ExamEid = 2, Score = 91 },
             new Result{StudentSid = 1,ExamEid = 3, Score = 86 },
             new Result{StudentSid = 1,ExamEid = 4, Score = 95 },
             new Result{StudentSid = 1,ExamEid = 5, Score = 97 },

             new Result{StudentSid = 2,ExamEid = 1, Score = 96 },
             new Result{StudentSid = 2,ExamEid = 2, Score = 75 },
             new Result{StudentSid = 2,ExamEid = 3, Score = 77 },
             new Result{StudentSid = 2,ExamEid = 4, Score = 72 },
             new Result{StudentSid = 2,ExamEid = 5, Score = 94 },
            };
            results.ForEach(r => esc.Results.Add(r));
            esc.SaveChanges();*/
        }

        public static void ShowData()
        {
            ExamStudentContainer esc = new ExamStudentContainer();
            var exams = esc.Exams;
            Console.WriteLine("Exams");
            foreach(var e in exams)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",e.Eid,e.Ename,e.Date,e.TotalMarks);
            }

            var students = esc.Students;
            Console.WriteLine("Students");
            foreach(var s in students)
            {
                Console.WriteLine("{0}\t{1}",s.Sid,s.Sname);
            }

            var results = esc.Results;
            Console.WriteLine("Results...");
            foreach(var r in results)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",r.Rid,r.StudentSid,r.Student.Sname,r.Exam.Ename,r.Score);
            }
        }
    }
}
