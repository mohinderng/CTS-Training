using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> clst = new List<Course>();
            {
                clst.Add(new Course { Cid = 1001, Cname = "Vinod++", Fees = 4000});
                clst.Add(new Course { Cid = 1002, Cname = "Vinod on Rails", Fees = 5000 });
                clst.Add(new Course { Cid = 1003, Cname = "Vinod#", Fees = 6000 });
                clst.Add(new Course { Cid = 1004, Cname = "Vinodthon", Fees = 8000 });
            }

            var query = from aq in clst select aq;
            foreach(var q in query)
              {
                Console.WriteLine("{0}\t{1}\t{2}", q.Cid, q.Cname, q.Fees);
            }
        }
    }
}
