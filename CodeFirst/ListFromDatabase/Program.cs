using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFromDatabase
{
    abstract class Program
    {

        static void Main(string[] args)
        {
            List<string> names = new List<string>()
            {
                "Andreas",
                "Jimmy",
                "Erik",
                "Anders",
                "Rudolf",
                "Sara",
                "Janne",
                "Ahmed"
            };
            List<string> namesStartingWithA = GetNamesStartingWithA(names);
            //foreach (string name in names)
            //{
            //    if (name.StartsWith("A"))
            //    {
            //        namesStartingWithA.Add(name);
            //    }

            //}
            foreach (string name in namesStartingWithA)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }

        public static List<string> GetNamesStartingWithA(List<string> names)
        {
            List<string> namesStartingWithA = new List<string>();
            foreach (string name in names)
            {
                if (name.StartsWith("A"))
                {
                    namesStartingWithA.Add(name);
                }

            }
            return namesStartingWithA;
        }
    }
}
