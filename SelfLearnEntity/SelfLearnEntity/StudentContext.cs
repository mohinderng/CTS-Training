using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SelfLearnEntity
{
    class StudentContext:DbContext
    {
        public StudentContext() { }
        public DbSet<Student> Students { get; set; }
    }
}
