using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SirEntity
{
    class Customer
    {
        [Key]
        public int Cid { get; set; }
        public string Cname { get; set; }
        public string Cadress { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
