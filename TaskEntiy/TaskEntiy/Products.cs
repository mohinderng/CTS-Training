using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TaskEntiy
{
    public class Products
    {
        [Key]
        public int Pid { get; set; }
        public string Pname { get; set; }
        public double Price { get; set; }
        public int Qty { get; set; }
    }
}
