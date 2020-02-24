using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirst
{
    class Program
    {
        static SirDbEntities sdb = new SirDbEntities();
        static void Main(string[] args)
        {
            AllCustomers();

            AllProducts();

            AllPurchases();

        }

        private static void AllPurchases()
        {
            Console.WriteLine("Purchases");
            var purchase = sdb.Purchases;
            foreach (var pr in purchase)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", pr.Id, pr.Cid, pr.Pid, pr.OrderDate, pr.Customer.Cname, pr.Product.Pname);
            }
        }

        private static void AllProducts()
        {
            Console.WriteLine("Products...");
            var products = sdb.Products;
            foreach (var p in products)
            {
                Console.WriteLine("{0}\t{1}\t{2}", p.Pid, p.Pname, p.Price);
            }
        }

        private static void AllCustomers()
        {
            Console.WriteLine("Customer names...");
            var customers = sdb.Customers;
            foreach (var c in customers)
            {
                Console.WriteLine("{0}\t{1}\t{2}", c.Cid, c.Cname, c.Cadress);
            }
        }
    }
}
