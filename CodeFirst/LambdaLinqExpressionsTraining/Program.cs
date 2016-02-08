using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaLinqExpressionsTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>()
            {
                new Person() {ID = 1, FirstName = "Jimmy", LastName = "Gustavsson", BirthDate = DateTime.Now.AddYears(32)},
                new Person() {ID = 1, FirstName = "Angelica", LastName = "Svensson", BirthDate = DateTime.Now.AddYears(32)},
                new Person() {ID = 1, FirstName = "Alexandra", LastName = "Olofsson", BirthDate = DateTime.Now.AddYears(32)},
                new Person() {ID = 1, FirstName = "Kim", LastName = "Jönsson", BirthDate = DateTime.Now.AddYears(32)},
                new Person() {ID = 1, FirstName = "Andre", LastName = "Sjöland", BirthDate = DateTime.Now.AddYears(32)},
                new Person() {ID = 1, FirstName = "Alexandra", LastName = "Bengtsson", BirthDate = DateTime.Now.AddYears(32)}

            };
            IEnumerable<Person> personsStartsWithA = persons.Where(p => p.FirstName.StartsWith("A"))
                .OrderBy(p => p.LastName);
            foreach (Person person in personsStartsWithA)
            {
                Console.WriteLine("Name: " + person.FirstName + " " + person.LastName);
            }
            Console.ReadLine();
        }
        
    }
}
