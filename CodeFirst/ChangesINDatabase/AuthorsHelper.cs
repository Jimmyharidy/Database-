using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangesINDatabase
{
    public static class AuthorsHelper
    {
        public static List<Author> GetAllAuthors()
        {
            using (var ctx = new BooksEntities())
            {
                List<Author> allAuthors = ctx.Authors.ToList();
                return allAuthors;
            }
            
            
        }

        public static Author GetAuthorsById(int id)
        {
            using (var ctx = new BooksEntities())
            {
                Author author = ctx.Authors.Find(id);
                return author;
            }
        }

        public static int AddNewAuthor(string newAuthorFirstName, string newAuthorLastName)
        {
            using (var ctx = new BooksEntities())
            {
                Author newAuthor = new Author();

                newAuthor.FirstName = newAuthorFirstName;
                newAuthor.LastName = newAuthorLastName;

                ctx.Authors.Add(newAuthor);

                ctx.SaveChanges();
                return newAuthor.AuthorID;
            }
        }

        public static void UpdateAuthorName(int authorId, string newFirstName, string newLastName)
        {
            //Author authorToUpdate = GetAuthorsById(authorId);

            using (var ctx = new BooksEntities())
            {
                Author authorToUpdate = ctx.Authors.Find(authorId);

                authorToUpdate.FirstName = newFirstName;
                authorToUpdate.LastName = newLastName;

                ctx.SaveChanges();
            }
        }

        public static void DeleteAuthor(int authorId)
        {
            using (var ctx = new BooksEntities())
            {
                Author authorToDelete = ctx.Authors.Find(authorId);
                if (authorToDelete != null)
                {
                    ctx.Authors.Remove(authorToDelete);
                    ctx.SaveChanges();
                }
                
            }
        }
    }
}
