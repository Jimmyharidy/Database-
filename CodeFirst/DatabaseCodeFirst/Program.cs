using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new School())
            {
                Student student = new Student()
                {FirstName = "Jimmy", LastName = "Svensson", Age = 32};
                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
        }
    }
}
