using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst2
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertData();
            ShowAll();
        }

        public static void InsertData()
        {
            
            
                Model1Container ctx = new Model1Container();
                var categories = new List<Category> {

                new Category {Ctype ="Men"},
                new Category {Ctype = "Women"},
                new Category {Ctype = "Baby"},
                 
            };
                categories.ForEach(s => ctx.Categories.Add(s));
                ctx.SaveChanges();


                var products = new List<Product>
            {
                new Product{Pname="Comb",Price="50", CategoryCid =2  },
                new Product{Pname="Baby Powder",Price="80",CategoryCid=3  },
                new Product{Pname="Detergent",Price="276",CategoryCid=1  }
                
            };
                products.ForEach(p => ctx.Products.Add(p));
                ctx.SaveChanges();
            }

        public static void ShowAll()
        {
            Model1Container ctx = new Model1Container();
            var categories = ctx.Categories;

            foreach (var cs in categories)
            {
                Console.WriteLine("{0}\t{1}", cs.Cid, cs.Ctype);
            }

            Console.WriteLine("\nProducts...\n");
            var products = ctx.Products;
            foreach (var prd in products)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", prd.Pid, prd.Pname, prd.Price,prd.CategoryCid,prd.Category.Ctype);
            }

        }
    }
    }


