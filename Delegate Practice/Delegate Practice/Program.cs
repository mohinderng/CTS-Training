using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Practice
{
    public delegate int AddDelegate(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            AddDelegate ad = new AddDelegate(p.Add);
            int d = ad(2,5);
            Console.WriteLine(d);
        }

        public int Add(int a, int b)
        {
            int c;
            c = a + b;
            return c;
        }
    }
}
