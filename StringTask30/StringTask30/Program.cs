using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTask30
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());

            string a = num.ToString();

            foreach(char i in a)
            {
                switch(i)
                {
                    case '1':
                        Console.Write("One ");
                        break;

                    case '2':
                        Console.Write("Two ");
                        break;

                    case '3':
                        Console.Write("Three ");
                        break;

                    case '4':
                        Console.Write("Four ");
                        break;

                    case '5':
                        Console.Write("Five ");
                        break;

                    case '6':
                        Console.Write("Six ");
                        break;

                    case '7':
                        Console.Write("Seven ");
                        break;

                    case '8':
                        Console.Write("Eight ");
                        break;

                    case '9':
                        Console.Write("Nine ");
                        break;

                    case '0':
                        Console.Write("Zero ");
                        break;

                    default:
                        Console.Write("Out of Bounds");
                        break;
                }
            }

            


        }
    }
}

           
          /* r = 1;
           while (rev>0)
            {
                r = rev % 10;
                rev = rev / 10;
            
                switch (r)
                {
                    case 1:
                        Console.Write("One ");
                        break;

                    case 2:
                        Console.Write("Two ");
                        break;
                    case 3:
                        Console.Write("Three ");
                        break;

                    case 4:
                        Console.Write("Four ");
                        break;

                    case 5:
                        Console.Write("Five ");
                        break;

                    case 6:
                        Console.Write("Six ");
                        break;

                    case 7:
                        Console.Write("Seven ");
                        break;

                    case 8:
                        Console.Write("Eight ");
                        break;

                    case 9:
                        Console.Write("Nine ");
                        break;

                    case 0:
                        Console.Write("Zero ");
                        break;

                    default:
                        Console.Write("Out of Bound");
                        break;
                }
            }
        }
    }
}*/
