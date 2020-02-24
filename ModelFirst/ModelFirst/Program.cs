using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
           InsertData();
           ShowData();
        }

        public static void InsertData()
        {
            Model1Container mc = new Model1Container();
            var categories = new List<Category>{
                new Category { Cid = 1, CatType = "Baby", ProductPid=2},
                new Category { Cid = 2, CatType = "Men", ProductPid=1},
                new Category { Cid = 1, CatType = "Baby", ProductPid=2},
                new Category { Cid = 3, CatType = "Women", ProductPid=3}
            };

            categories.ForEach(s => mc.Categories.Add(s));
            mc.SaveChanges();

            var products = new List<Product>
            {
                new Product {Pid = 1,Ptitle="Deo",Price =200,Cid=2},
                new Product {Pid = 2,Ptitle="Powder",Price=50,Cid=1},
                new Product {Pid = 3,Ptitle="Comb",Price=30,Cid=3 }
        };
            products.ForEach(p => mc.Products.Add(p));
            mc.SaveChanges();
        }

        public static void ShowData()
        {
            Model1Container mc = new Model1Container();
            var categories = mc.Categories;

            Console.WriteLine("Categories...");
            foreach(var c in categories)
            {
                Console.WriteLine("{0}\t{1}",c.Cid,c.CatType);
            }

            var products = mc.Products;
            Console.WriteLine("Products...");
            foreach(var pr in products )
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",pr.Pid,pr.Ptitle,pr.Price,pr.Cid,pr.Category.CatType);
            }
        }
    }
}
