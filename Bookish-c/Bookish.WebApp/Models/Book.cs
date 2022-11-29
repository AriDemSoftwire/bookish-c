using System.ComponentModel.DataAnnotations;

namespace Bookish.WebApp.Models
{
    public class Book
    {
        [Key]
        public int ISBN { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public int totalCopies { get; set; }
    }
}