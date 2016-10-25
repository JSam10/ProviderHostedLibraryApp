using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LibraryHOLTest1Web.Models
{
    public class LibraryEntities : DbContext
    {
        public LibraryEntities() : base("name = LibraryEntities")
        {
            Database.SetInitializer<LibraryEntities>(new DatabaseInitializer());
        }
        public  DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}