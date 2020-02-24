using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReverseFunc;

namespace ReverseTask
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassNew obj = new ClassNew();
            obj.n = 123;

            Console.WriteLine(obj.RevNumber());
        }
    }
}
