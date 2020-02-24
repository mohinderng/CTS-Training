using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TaskEntiy
{
    class Customer
    {
        [Key]
        public int Cid { get; set; }
        public string Cname { get; set; }
        public long Contact { get; set; } 
        //public int Qty { get; set; }

       public List<Products> Product { get; set; }
    }
}
