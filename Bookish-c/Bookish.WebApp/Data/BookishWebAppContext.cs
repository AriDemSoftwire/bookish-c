using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bookish.WebApp.Models;

namespace Bookish.WebApp.Data
{
    public class BookishWebAppContext : DbContext
    {
        public virtual DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<BorrowedBook> BorrowedBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=_oCoqG5q5L;Database=bookishc");

    }
}
