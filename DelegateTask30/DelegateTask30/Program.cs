using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTask30
{
    class Program
    {
       public delegate int areadel(int x, int y);
        static void Main(string[] args)
        {
            areadel d = new areadel(AreaRec);
            areadel c = new areadel(AreaTri);

            
            Console.WriteLine("The area of rectangle is {0}", d(4, 6));
            
            Console.WriteLine("The area of triangle is {0}", c(4, 6));

        }

        public static int AreaRec(int l, int b)
        {
            return l*b;
        }

        public static int AreaTri(int b, int h)
        {
            return (b * h) / 2;
        }
    }
}
