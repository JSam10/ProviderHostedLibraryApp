using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryHOLTest1Web.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string AuthorName { get; set; }
        public List<Book> AuthorBooks { get; set; }
    }
}