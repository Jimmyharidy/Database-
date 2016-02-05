using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTraining2
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new Championship()) { Player player = new Player()
            { PlayerId = 1, FirstName = "Awesome Gam er", LastName = "JimmyBoy", Age = 33, SocialSecurityNumber = 9904258877, Address = "testgatan 77b", PhoneNumber = 733586967};
              ctx.Players.Add(player); ctx.SaveChanges(); }
        }
        }
    }

