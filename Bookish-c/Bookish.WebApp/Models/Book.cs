using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookish.WebApp.Models
{
    [Table("bookstable", Schema = "public")]
    public class Book
    {
        [Key]
        public int isbn { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int totalcopies { get; set; }

    }
}