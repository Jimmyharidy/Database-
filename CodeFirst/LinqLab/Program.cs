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

            //Linq();
            //LinqMedLambda();
            LinqMedLambdaObjektLista();
        }

        private static void LinqMedLambdaObjektLista()
        {
            List<Employee> employees = new List<Employee>(){
                new Employee() {ID=1, FirstName = "Jimmy", LastName = "Gunnarsson", Age = 32, Department = "IT department", HireDate = new DateTime(year:2015, month:01, day:28)},
                new Employee() {ID=2, FirstName = "Angelica", LastName = "Svensson", Age = 30, Department = "Reception department", HireDate = new DateTime(year:2016, month:01, day:10)},
                new Employee() {ID=3, FirstName = "Andre", LastName = "Hansson", Age = 28, Department = "Industry department", HireDate = new DateTime(year:2015, month:08, day:17)},
                new Employee() {ID=4, FirstName = "Jonas", LastName = "Olofsson", Age = 26, Department = "Warehouse department", HireDate = new DateTime(year:2015, month:02, day:02)},
                new Employee() {ID=5, FirstName = "Johan", LastName = "Nilsson", Age = 25, Department = "IT department", HireDate = new DateTime(year:2010, month:10, day:10)},
                new Employee() {ID=6, FirstName = "Svante", LastName = "Gustavsson", Age = 23, Department = "Industry department", HireDate = new DateTime(year:2000, month:11, day:30)},
                new Employee() {ID=7, FirstName = "Ivan", LastName = "Blomqvist", Age = 20, Department = "Warehouse department", HireDate = new DateTime(year:2016, month:02, day:08)},
                new Employee() {ID=8, FirstName = "Jakob", LastName = "Brinck", Age = 38, Department = "Bussiness department", HireDate = new DateTime(year:2015, month:06, day:22)},
                new Employee() {ID=9, FirstName = "Ingrid", LastName = "Sjöland", Age = 41, Department = "Reception department", HireDate = new DateTime(year:1997, month:04, day:28)},
                new Employee() {ID=10, FirstName = "Johnny", LastName = "Knutsson", Age = 50, Department = "Bussiness department", HireDate = new DateTime(year:1990, month:02, day:02)}

            };

            bool isInMenu = true;
            while (isInMenu)
            {
                CreateMenu();

                int choice = 0;
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:

                        IEnumerable<Employee> showAllNamesSortedByLastName = employees.OrderBy(e => e.LastName);
                        foreach (Employee employee in showAllNamesSortedByLastName)
                            Console.WriteLine(employee.LastName);

                        break;
                    case 2:

                        IEnumerable<Employee> showAllNamesSortedByFirstName = employees.OrderBy(e => e.FirstName);
                        foreach (Employee employee in showAllNamesSortedByFirstName)
                            Console.WriteLine(employee.FirstName);

                        break;
                    case 3:

                        IEnumerable<Employee> showPersonsInDepartmentBussiness = employees.Where(e => e.Department.Contains("Bussiness"));
                        foreach (Employee employee in showPersonsInDepartmentBussiness)
                            Console.WriteLine(employee.FirstName);

                        break;
                    case 4:

                        Console.WriteLine("Please enter your search name:");
                        string searchText = Console.ReadLine();
                        IEnumerable<Employee> searchForPersons = employees.Where(e => e.FirstName.Contains(searchText));
                        foreach (Employee employee in searchForPersons)
                            Console.WriteLine("Result: " + employee.FirstName);

                        break;
                    case 5:
                        isInMenu = false;
                        break;
                    default:
                        Console.WriteLine("Please choose a correct choice!");
                        break;
                }
                Console.WriteLine("\nPress a key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }


        private static void CreateMenu()
        {
            Console.WriteLine("Please choose an option");
            Console.WriteLine("1.Show all names sorted by lastname");
            Console.WriteLine("2.Show all names sorted by firstname");
            Console.WriteLine("3.List all employees within the same department");
            Console.WriteLine("4.Search name");
            Console.WriteLine("5. Exit program");
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
