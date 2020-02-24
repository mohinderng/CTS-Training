using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookApp
{
    class Book
    {
        [Key]
        public int bid { get; set; }
        public string tytle {get;set;}
        public string price { get; set; }

        public virtual ICollection<Detail> Details { get; set; }
    }
}
