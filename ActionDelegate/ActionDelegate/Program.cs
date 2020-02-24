using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> Multiply = (x, y) => Console.WriteLine("{0}", x * y);

            Func<int, int, double> ad = (x, y) => x + y;

            List<Student> lst = new List<Student>
            {
                new Student {ID=1, StudentName = "Arvind",Course="C#"},
                new Student {ID=2, StudentName = "Vinod",Course="Java"},
            };

            lst.Sort();
            foreach(var s in lst)
            { 
                Console.WriteLine("{0}\t{1}\t{2}",s.ID,s.Course,s.)
            Predicate<Student> fst = x => x.ID == 2;
            Student st = lst.Find(fst);
            Console.WriteLine("{0}\t{1}\t{2}", st.ID, st.StudentName, st.Course);
        }
    }
}
