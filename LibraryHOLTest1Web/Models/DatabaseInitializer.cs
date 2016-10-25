using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LibraryHOLTest1Web.Models
{
    public class DatabaseInitializer : DropCreateDatabaseAlways<LibraryEntities>
    {
        public override void InitializeDatabase(LibraryEntities context)
        {
            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, string.Format("ALTER DATABASE [{0}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE", context.Database.Connection.Database));

            base.InitializeDatabase(context);
        }

        protected override void Seed(LibraryEntities context)
        {
            IList<Author> defaultAuthors = new List<Author>();
            IList<Category> defaultCategories = new List<Category>();
            IList<Book> defaultBooks = new List<Book>();

            defaultCategories.Add(new Category() { CategoryName = "Thriller" });
            defaultCategories.Add(new Category() { CategoryName = "Fiction" });
            defaultCategories.Add(new Category() { CategoryName = "Suspense" });

            defaultAuthors.Add(new Author() { AuthorName = "Rowling" });
            defaultAuthors.Add(new Author() { AuthorName = "Archer" });
            defaultAuthors.Add(new Author() { AuthorName = "Forsyth" });

            defaultBooks.Add(new Book() { BookTitle = "Harry Potter and the Half Blood Prince", BookAuthor = defaultAuthors.FirstOrDefault(a => a.AuthorName == "Rowling"), BookCategory = defaultCategories.FirstOrDefault(c => c.CategoryName == "Fiction") });
            defaultBooks.Add(new Book() { BookTitle = "Harry Potter and the Deathly Hallows", BookAuthor = defaultAuthors.FirstOrDefault(a => a.AuthorName == "Rowling"), BookCategory = defaultCategories.FirstOrDefault(c => c.CategoryName == "Fiction") });
            defaultBooks.Add(new Book() { BookTitle = "Day of the Jackal", BookAuthor = defaultAuthors.FirstOrDefault(a => a.AuthorName == "Forsyth"), BookCategory = defaultCategories.FirstOrDefault(c => c.CategoryName == "Thriller") });
            defaultBooks.Add(new Book() { BookTitle = "Paths of Glory", BookAuthor = defaultAuthors.FirstOrDefault(a => a.AuthorName == "Archer"), BookCategory = defaultCategories.FirstOrDefault( c => c.CategoryName == "Suspense") });
            defaultBooks.Add(new Book() { BookTitle = "Kane and Abel", BookAuthor = defaultAuthors.FirstOrDefault(a => a.AuthorName == "Archer"), BookCategory = defaultCategories.FirstOrDefault(c => c.CategoryName == "Suspense") });

            foreach (Category c in defaultCategories)
            {
                context.Categories.Add(c);
            }

            foreach (Author a in defaultAuthors)
            {
                context.Authors.Add(a);
            }

            foreach (Book c in defaultBooks)
            {
                context.Books.Add(c);
            }
            
            base.Seed(context);
        }

    }
}