using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bookish.Web.Models
{
    public class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int numOfCopies { get; set; }
    }
}