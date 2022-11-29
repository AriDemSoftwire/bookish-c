﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bookish.WebApp.Models;

namespace Bookish.WebApp.Data
{
    public class BookishWebAppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=_oCoqG5q5L;Database=bookishc");

        public virtual DbSet<Book> Book { get; set; }
    }
}
