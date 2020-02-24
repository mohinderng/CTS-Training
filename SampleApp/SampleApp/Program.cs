using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            String ename;

            Console.WriteLine("Enter Your Name");

            ename = Console.ReadLine();

            Console.WriteLine("Enter the age");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Congratulations Mr/Ms{0} on your {1} birthday", ename, age);

            Console.ReadKey();
        }
    }
}
