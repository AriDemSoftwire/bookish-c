using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookish.WebApp.Models
{
    public class BookFullInfo
    {
        [Key]
        public int isbn { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int totalcopies { get; set; }
        public int availablecopies { get; set; }
        public List<string> username { get; set; }
        public List<string> returndate { get; set; }
    }
}
