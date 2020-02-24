using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BookApp
{
    class Detail
    {
        [Key]
        public int sno { get; set; }
        public int bid { get; set; }
        public int aid{get;set;}
        public virtual Book Books { get; set; }
        public virtual Author Authors { get; set; }
    }
}
