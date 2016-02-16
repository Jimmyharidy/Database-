using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************");
            Console.WriteLine("*************** Menu ***************");
            Console.WriteLine("************************************");

            Applications applications = new Applications();
            applications.StartMenu();

            Console.WriteLine();
            Console.WriteLine("----------");
            Console.ReadLine();
            
        }
    }
}
