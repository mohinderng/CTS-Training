using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ShowAll();
        }

        public static void InsertData()
        {
            CustomerContext ctx = new CustomerContext();
            var customers = new List<Customer> {

                new Customer {Cname="Anand",Cadress="Chennai"},
                new Customer {Cname="Musa",Cadress="Hyderabad"},
                new Customer {Cname="Mani",Cadress="Chennai"},
                 new Customer {Cname="Sree",Cadress="Vijayawada"}
            };
            customers.ForEach(s => ctx.Customers.Add(s));
            ctx.SaveChanges();


            var products = new List<Product>
            {
                new Product{Pname="Rice",Price=76  },
                new Product{Pname="Dal",Price=176  },
                new Product{Pname="Detergent",Price=276  },
                new Product{Pname="Soap",Price=376  }
            };
            products.ForEach(p => ctx.Products.Add(p));
            ctx.SaveChanges();

            var purchases = new List<Purchase> {

                new Purchase{OrderDate=Convert.ToDateTime("09-02-2020"),Pid=1,Cid=2},
                new Purchase{OrderDate=Convert.ToDateTime("10-02-2020"),Pid=2,Cid=1},
                new Purchase{OrderDate=Convert.ToDateTime("10-02-2020"),Pid=3,Cid=2},
                new Purchase{OrderDate=Convert.ToDateTime("12-02-2020"),Pid=4,Cid=4},
            };
            purchases.ForEach(pr => ctx.Purchases.Add(pr));
            ctx.SaveChanges();
        }

        public static void ShowAll()
        {
            CustomerContext ctx = new CustomerContext();
            var customers = ctx.Customers;

            foreach(var cs in customers)
            {
                Console.WriteLine("{0}\t{1}\t{2}", cs.Cid, cs.Cname, cs.Cadress);
            }

            Console.WriteLine("\nProducts...\n");
            var products = ctx.Products;
            foreach(var prd in products)
            {
                Console.WriteLine("{0}\t{1}\t{2}", prd.Pid, prd.Pname, prd.Price);
            }


            Console.WriteLine("\nPurchases...\n");
            var purch = ctx.Purchases;
            foreach(var pc in purch)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5},{6}",pc.Id,pc.OrderDate,pc.Pid,pc.Product.Pname,pc.Product.Price,pc.Cid,pc.Customer.Cname );
            }
        }
            }
    }

