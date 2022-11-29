using bookish_c_test.Models;
using Microsoft.EntityFrameworkCore;

namespace bookish_c_test.Connection
{
    public class TestDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=_oCoqG5q5L;Database=bookishc");

        public virtual DbSet<Book> Book { get; set; }
    }
}