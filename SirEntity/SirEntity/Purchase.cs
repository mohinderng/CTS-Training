using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SirEntity
{
    class Purchase
    {
        public int Id{ get; set; }
        public DateTime OrderDate { get; set; }
        public int Cid { get; set; }
        public int Pid { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
