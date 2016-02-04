using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCodeFirst
{
    class School: DbContext
    {
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }

        public DbSet<Education> Educations { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
