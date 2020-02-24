using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStructures1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,i,product,sum=0;

            Console.WriteLine("Enter the number");

            a = int.Parse(Console.ReadLine());

            if (a < 10)
            {
                for (i = 1; i <= 10; i++)
                {
                    product = a * i;
                }
            }

            else if (a >= 10 && a <= 30)
            {
                for (i = 1; i <= 10; i++)
                {
                    sum = a + i;
                }
                Console.WriteLine("The sum is {0}", sum);

            }

            else
            {
                Console.WriteLine("Moving the control to Switch Case");

                switch (a)
                {
                    case 30:
                        Console.WriteLine("The value of a is {0}", a);
                        break;

                    case 40:
                        Console.WriteLine("The value of a is {0}", a);
                        break;

                    default:
                        Console.WriteLine("I don't know the value");
                        break;

                }
            }
      
        }
    }
}
