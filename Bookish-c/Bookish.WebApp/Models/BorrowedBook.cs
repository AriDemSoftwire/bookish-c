using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookish.WebApp.Models
{
    [Table("booksborrowed", Schema = "public")]
    public class BorrowedBook
    {
        [Key]
        public int isbn { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int totalcopies { get; set; }
    }
}
