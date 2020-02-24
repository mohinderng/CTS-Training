using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunTimeAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            DataLayer dl = new DataLayer();
            dl.GetData();
            Console.ReadKey();
        }
    }
}
