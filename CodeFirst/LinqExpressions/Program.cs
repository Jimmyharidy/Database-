using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExpressions
{
    class Program
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
            List<Person>persons = new List<Person>()
            {
                new Person() {ID = 1, FirstName = "Jimmy", LastName = "Svensson", BirthDate = DateTime.Now.AddYears(-35)},
                new Person() {ID = 1, FirstName = "Kalle", LastName = "Olofsson", BirthDate = DateTime.Now.AddYears(-30)},
                new Person() {ID = 1, FirstName = "Jakob", LastName = "Gustavsson", BirthDate = DateTime.Now.AddYears(-28)},
                new Person() {ID = 1, FirstName = "Andreas", LastName = "Petersson", BirthDate = DateTime.Now.AddYears(-27)},
                new Person() {ID = 1, FirstName = "Anders", LastName = "Hansson", BirthDate = DateTime.Now.AddYears(-25)},
                new Person() {ID = 1, FirstName = "Angelica", LastName = "Kjellsson", BirthDate = DateTime.Now.AddYears(-20)},

            };
            // Linq Expression to get names starting with A.
            // Example with List<string>

            IEnumerable<string>namesStartWithA =
                from name in names
                where name.StartsWith("A")
                select name;
          
        // Example with List<Person>
        IEnumerable<Person> namesStartingA =
             from p in persons
             where p.FirstName.StartsWith("A")
             select p;
        
            // Example with list<Person>2
            IEnumerable<string> namesSpecific =
                from p in persons
                where p.FirstName == "Jimmy" || p.FirstName == "Mormor"
                select p.FirstName;
            foreach (Person person in namesStartingA)
            {
                Console.WriteLine(person.FirstName);
                
            }
            Console.ReadLine();
        }
        //        foreach (string name in namesStartingWithA)
        //        {
        //            Console.WriteLine(name);
        //        }
        //Console.ReadLine();
        //public static List<string> GetNamesStartingWithA(List<string> names)
        //{
        //    List<string> namesStartingWithA = new List<string>();
        //    foreach (string name in names)
        //    {
        //        if (name.StartsWith("A"))
        //        {
        //            namesStartingWithA.Add(name);
        //        }

        //    }
        //    return namesStartingWithA;
        //}
    }
}
