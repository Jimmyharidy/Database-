using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new School())
            {
                Student student = new Student()
                {
                    FirstName = "Jimmy",
                    LastName = "JimmyBoy", Age = 33,
                    PhoneNumber = 0708554466,
                    SocialSecurityNumber = 9806253878
                    
                };
                ctx.Students.Add(student);
                ctx.SaveChanges();

            }
           
        }
    }
}
