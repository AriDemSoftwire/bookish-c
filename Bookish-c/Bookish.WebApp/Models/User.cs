using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookish.WebApp.Models
{
    [Table("userstable", Schema = "public")]
    public class User
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string userpass { get; set; }
    }
}
