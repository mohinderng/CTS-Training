using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a,b;
            double product;
            Console.WriteLine("Enter the two numbers");

            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());

            product = a * b;

            Console.WriteLine("The product of n1={0} and n2{1} is {2} ", a, b, product);

        }
    }
}
