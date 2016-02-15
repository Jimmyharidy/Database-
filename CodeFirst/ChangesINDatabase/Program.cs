using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangesINDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("***************** Author Menu *****************");
            Console.WriteLine("***********************************************");
            Console.WriteLine();
            Console.WriteLine();

            Applications app = new Applications();
            app.Start();

            Console.WriteLine();
            Console.WriteLine("----------");
            Console.ReadLine();
        }
    }
}
