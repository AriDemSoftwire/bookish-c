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
        public BookishWebAppContext (DbContextOptions<BookishWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<Bookish.WebApp.Models.Book> Book { get; set; } = default!;
    }
}
