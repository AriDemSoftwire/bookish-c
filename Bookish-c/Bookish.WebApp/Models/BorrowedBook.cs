using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookish.WebApp.Models
{
    [Table("booksborrowed", Schema = "public")]
    public class BorrowedBook
    {
        [Key]
        public int isbn { get; set; }
        public int userid { get; set; }
        public int copyid { get; set; }
        public string returndate { get; set; }
    }
}
