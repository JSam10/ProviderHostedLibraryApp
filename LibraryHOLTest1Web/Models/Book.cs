using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryHOLTest1Web.Models
{
    public class Book
    {
        
        public int BookID { get; set; }
        public int AuthorID { get; set; }
        public int CategoryID { get; set; }
        public string BookTitle { get; set; }
        [DataType(DataType.DateTime)]
        
        public DateTime? Year { get; set; }
        public string Language { get; set; }
        public int Copies { get; set; }
        public Author BookAuthor { get; set; }
        public Category BookCategory { get; set; }

        

    }
}