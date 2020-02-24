using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
     
       static void Main(string[] args)
        {
           
            string a,b;

            Console.WriteLine("Enter the name and age");

        
            b = Console.ReadLine();
            a = Console.ReadLine();
            string p2 = Greetings(a,b);

            Console.WriteLine(p2);


            Console.ReadLine();
        }

        public static string Greetings(string age, string name)
        {

            string s = "Congratulations Mr/Mrs " + name + " on your " + age + " birthday";
            return s;

        }
    }
}
