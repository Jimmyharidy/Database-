using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {

            Application app = new Application();
            app.Start();
            
        }

        private static void LinqMedLambda()
        {
            List<string> names = new List<string>()
           {
               "Jimmy", "Andreas", "Angelica", "Karl", "Johan", "Alexandra", "Fredrik", "Andre"
           };
            IEnumerable<string> showAllNamesThatContainsA = names.Where(n => n.Contains("a"));
            IEnumerable<string> namesStartWithAandNoS = names.Where(n => n.StartsWith("A") && !n.Contains("s"));
            Console.WriteLine("Please choose an option");
            Console.WriteLine("1.Show all names that contains an A");
            Console.WriteLine("2.Show all names that starts with an A and contains the letter S");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                foreach (string name in showAllNamesThatContainsA)
                {
                    Console.WriteLine(name);
                }
            }
            else

                foreach (string name in namesStartWithAandNoS)
                {
                    Console.WriteLine(name);
                }

            Console.ReadLine();
        }

        private static void Linq()
        {
            List<string> names = new List<string>()
           {
               "Jimmy", "Andreas", "Angelica", "Karl", "Johan", "Alexandra", "Fredrik", "Andre"
           };
            IEnumerable<string> personsStartWithA = from name in names
                                                    where name.StartsWith("A")
                                                    select name;

            Console.WriteLine("Please choose an option");
            Console.WriteLine("1.Show all names");
            Console.WriteLine("2.Show all names that starts with an A");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            }
            else

                foreach (string name in personsStartWithA)
                {
                    Console.WriteLine(name);
                }

            Console.ReadLine();
        }
    }
}
