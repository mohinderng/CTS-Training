using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            obj.No1 = 45;
            obj.No2 = 55;

            Console.WriteLine(obj.Add());
            Console.WriteLine(obj.Difference());
            Console.WriteLine(obj.Multiply());
            Console.WriteLine(obj.Division());
        }
    }
}
