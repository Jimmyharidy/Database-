using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTraining
{
    class School: DbContext
    {
       public int SchoolId { get; set; }
        public string SchoolName { get; set; }
        public string SchoolAddress { get; set; }
        public int SchoolNumber { get; set; }

        public DbSet<Education>Educations { get; set; }
        public DbSet<Student>Students { get; set; }
    }
}
