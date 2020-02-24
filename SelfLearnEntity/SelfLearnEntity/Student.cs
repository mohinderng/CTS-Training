using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SelfLearnEntity
{
    class Student
    {
        [Key]
        public int Sid { get; set; }
        public string Sname { get; set; }
        public string contact { get; set; }

    }
}
