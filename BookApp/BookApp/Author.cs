using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookApp
{
    class Author
    {
        [Key]
        public int aid { get; set; }
        public string name{get;set;}
        public string adress { get; set; }

        public virtual ICollection<Detail> Details { get; set; }
    }
}
