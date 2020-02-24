using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEntiy
{
    class Program
    {

        private static List<Products> GetPro()
        {
            List<Products> list = new List<Products>();
            int choice = 0;
            do
            {
                Products p = new Products();

                Console.WriteLine("Enter Product Name");
                p.Pname = Console.ReadLine();

                Console.WriteLine("Enter Price");
                p.Price = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter Qty");
                p.Qty = int.Parse(Console.ReadLine());

                list.Add(p);
                Console.WriteLine("Press 1 to add more products");
                choice = int.Parse(Console.ReadLine());
            } while (choice == 1);
            return list;
        }


        static void Main(string[] args)
        {
            addCust();


            Console.ReadKey();
        }

        private static void addCust()
        {
            CusProContext cpc = new CusProContext();
            Customer c = new Customer();

            Console.WriteLine("Enter Customer Name");
            c.Cname = Console.ReadLine();
            Console.WriteLine("Enter contact number");
            c.Contact = long.Parse(Console.ReadLine());
            c.Product = GetPro();

            cpc.CustomerTab.Add(c);
            cpc.SaveChanges();



        }
        
    }
    }

