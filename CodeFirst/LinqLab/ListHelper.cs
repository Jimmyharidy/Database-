using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab
{
    public static class ListHelper

    {
        static List<Employee> employees = new List<Employee>(){
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

        public static IEnumerable<Employee> NameSortedByLastName()
        {
            IEnumerable<Employee> showAllNamesSortedByLastName = employees.OrderBy(e => e.LastName);

            return showAllNamesSortedByLastName;

        }

        public static IEnumerable<Employee> NameSortedByFirstName()
        {
            IEnumerable<Employee> showAllNamesSortedByFirstName = employees.OrderBy(e => e.FirstName);
            return showAllNamesSortedByFirstName;
        }

        public static IEnumerable<Employee> GetPersonsInBussinessDepartment()
        {
            IEnumerable<Employee> showPersonsInDepartmentBussiness = employees.Where(e => e.Department.Contains("Bussiness"));
            return showPersonsInDepartmentBussiness;
        }

        public static IEnumerable<Employee> SearchingSpecifikPersons(string searchText)
        {
            
            IEnumerable<Employee> searchForPersons = employees.Where(e => e.FirstName.Contains(searchText));

            return searchForPersons;
        } 
    }

}
