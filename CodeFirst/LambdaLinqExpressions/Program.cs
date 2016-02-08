using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinqExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>()
            {
                new Person() {ID = 1, FirstName = "Jimmy", LastName = "Svensson", BirthDate = DateTime.Now.AddYears(-35)},
                new Person() {ID = 1, FirstName = "Kalle", LastName = "Olofsson", BirthDate = DateTime.Now.AddYears(-30)},
                new Person() {ID = 1, FirstName = "Jakob", LastName = "Gustavsson", BirthDate = DateTime.Now.AddYears(-28)},
                new Person() {ID = 1, FirstName = "Andreas", LastName = "Petersson", BirthDate = DateTime.Now.AddYears(-27)},
                new Person() {ID = 1, FirstName = "Anders", LastName = "Hansson", BirthDate = DateTime.Now.AddYears(-25)},
                new Person() {ID = 1, FirstName = "Angelica", LastName = "Kjellsson", BirthDate = DateTime.Now.AddYears(-20)},

            };
            IEnumerable<Person> personsStartingWithA = persons.Where(p => p.FirstName.StartsWith("A"))
                .OrderBy(p => p.LastName);

          Person personStartingWithA = persons.Where(p => p.FirstName.StartsWith("A"))
               .OrderBy(p => p.LastName).First();

            persons.Add(new Person() {ID = 6, FirstName = "Anna", LastName = "Gustavsson", BirthDate = DateTime.Now.AddYears(18)});

            foreach (Person person in personsStartingWithA)
            {
                Console.WriteLine("Name: " + person.FirstName + " " + person.LastName );
            }
            Console.ReadLine();
        }
    }
}
