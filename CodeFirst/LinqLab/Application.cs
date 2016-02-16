using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
   public class Application
    {
        public void CreateMenu()
        {
            Console.WriteLine("Please choose an option");
            Console.WriteLine("1.Show all names sorted by lastname");
            Console.WriteLine("2.Show all names sorted by firstname");
            Console.WriteLine("3.List all employees within the same department");
            Console.WriteLine("4.Search name");
            Console.WriteLine("5. Exit program");
        }
        public void Start()
        {

            bool isInMenu = true;
            while (isInMenu)
            {
                CreateMenu();

                int choice = 0;
                int.TryParse(Console.ReadLine(), out choice);

                switch (choice)
                {
                    case 1:

                        var allEmployeesByLastName = ListHelper.NameSortedByLastName();
                        foreach (Employee employee in allEmployeesByLastName)
                        {
                            Console.WriteLine(employee.LastName);
                        }

                        break;
                    case 2:

                        var allEmployeesByFirstName = ListHelper.NameSortedByFirstName();
                        foreach (Employee  employee in allEmployeesByFirstName)
                        {
                            Console.WriteLine(employee.FirstName);
                        }

                        break;
                    case 3:

                        var showPersonsFromBussinessDepartment = ListHelper.GetPersonsInBussinessDepartment();
                        foreach (Employee employee in showPersonsFromBussinessDepartment)
                        {
                            Console.WriteLine(employee.FirstName);
                        }

                        break;
                    case 4:

                        Console.WriteLine("Please enter your search name:");
                        string searchText = Console.ReadLine();
                        var SearchForPersons = ListHelper.SearchingSpecifikPersons(searchText);
                        foreach (Employee employee in SearchForPersons)
                        {
                            Console.WriteLine(employee.FirstName);
                        }

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
    }

}
