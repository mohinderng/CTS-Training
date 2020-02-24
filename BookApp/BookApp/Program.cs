using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookApp
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
            BookContext bc = new BookContext();

            Console.WriteLine("Books..\n");
            var books = new List<Book>
            {

                new Book{tytle="The Alchemist",price="50"},
                new Book{tytle="The Pilgrimage",price="70"},
                new Book{tytle="Five Point Someone",price="30"},
                new Book{tytle="The Art Of War",price="100"}
            };

            books.ForEach(b => bc.Books.Add(b));
            bc.SaveChanges();

            Console.WriteLine("Authors...\n");
            var authors = new List<Author>
            {
                new Author{name="Paulo Coehlo",adress="Brasil"},
                new Author{name="Chetan Bhagat",adress="India"},
                new Author{name="Sun Tzu",adress="China"}
            };

            authors.ForEach(a => bc.Authors.Add(a));
            bc.SaveChanges();

            Console.WriteLine("Details...\n");
            var details = new List<Detail>
            {
                new Detail {bid=1,aid=1 },
                new Detail {bid=2,aid=1 },
                new Detail {bid=3,aid=2 },
                new Detail {bid=4,aid=3 }

            };

            details.ForEach(d => bc.Details.Add(d));
            bc.SaveChanges();

        }

        public static void ShowData()
        {
            BookContext bc = new BookContext();
            var books = bc.Books;

            Console.WriteLine("Books..");
            foreach (var v in books)
            {
                Console.WriteLine("{0}\t{1}\t{2}", v.bid, v.tytle, v.price);
            }

            var authors = bc.Authors;
            Console.WriteLine("Authors...");
            foreach (var q in authors)
            {
                Console.WriteLine("{0}\t{1}\t{2}", q.aid, q.name, q.adress);
            }

            var details = bc.Details;
            Console.WriteLine("Details...");
            foreach (var d in details)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}", d.sno, d.bid, d.aid, d.Books.tytle, d.Authors.name, d.Books.price);
            }


        }
    }
}
