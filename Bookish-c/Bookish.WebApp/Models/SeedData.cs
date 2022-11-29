using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Bookish.WebApp.Data;
using System;
using System.Linq;
using Bookish.WebApp.Models;

namespace Bookish.WebApp.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new BookishWebAppContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<BookishWebAppContext>>()))
        {
            // Look for any movies.
            if (context.Book.Any())
            {
                return;   // DB has been seeded
            }
            context.Book.AddRange(
                new Book
                {
                    Title = "The Great Expectations",
                    Author = "C. Dickens",
                    totalCopies = 13
                },
                new Book
                {
                    Title = "If We Were Enemies",
                    Author = "M. Rio",
                    totalCopies = 18
                },
                new Book
                {
                    Title = "Egyptian Mythology",
                    Author = "Some Egyptian",
                    totalCopies = 2
                },
                new Book
                {
                    Title = "The Suitcase",
                    Author = "S. Dovlatov",
                    totalCopies = 83
                }
            );
            context.SaveChanges();
        }
    }
}
