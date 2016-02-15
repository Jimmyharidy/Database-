using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangesINDatabase
{
    public class Applications
    {
        public void Start()
        {
            Console.WriteLine("1. List All Authors");
            Console.WriteLine("2. Find author by id");
            Console.WriteLine("3. Add new author:");
            Console.WriteLine("4. Update Author Name");
            Console.WriteLine("5. Delete Author");
            Console.WriteLine();

            string choice;

            Console.WriteLine("Enter choice: ");
            choice = Console.ReadLine();

            Console.WriteLine();
            if (choice == "1")
            {
                Console.WriteLine("All Authors");
                Console.WriteLine();
                List<Author> allAuthors = AuthorsHelper.GetAllAuthors();

                foreach (Author author in allAuthors)
                {
                    Console.WriteLine("Author Name: " + author.FirstName + " " + author.LastName);
                }
            }
            if (choice == "2")
            {
                Console.Write("Enter author id: ");

                int authorId = int.Parse(Console.ReadLine());

                Author author = AuthorsHelper.GetAuthorsById(authorId);

                Console.WriteLine();
                if (author != null)
                {
                    Console.WriteLine("Author name is: " + author.FirstName + " " + author.LastName);
                }
                else
                {
                    Console.WriteLine("No author with that id was found");
                }
                

            }
            if (choice == "3")
            {
                string newAuthorFirstName;
                string newAuthorLastName;

                Console.Write("Enter New Author First Name:");
                newAuthorFirstName = Console.ReadLine();

                Console.WriteLine("Enter New Author Last Name:");
                newAuthorLastName = Console.ReadLine();

               int newAuthorId = AuthorsHelper.AddNewAuthor(newAuthorFirstName, newAuthorLastName);
                Console.WriteLine("Author created successfully, His/Shes id = " + newAuthorId);
            }
            if (choice == "4")
            {
                string authorNewFirstName;
                string authorNewLastName;

                int authorToUpdateId;
                Console.Write("Enter AuthorId to update: ");
                authorToUpdateId = int.Parse(Console.ReadLine());

                Console.Write("Enter new First Name: ");
                authorNewFirstName = Console.ReadLine();

                Console.WriteLine("Enter new Last Name: ");
                authorNewLastName = Console.ReadLine();

                AuthorsHelper.UpdateAuthorName(authorToUpdateId, authorNewFirstName, authorNewLastName);
            }
            if (choice == "5")
            {
                int authorId;

                Console.Write("Author Id of author to delete: ");
                authorId = int.Parse(Console.ReadLine());

                AuthorsHelper.DeleteAuthor(authorId);
            }
        }
        
        
    }
    
}
