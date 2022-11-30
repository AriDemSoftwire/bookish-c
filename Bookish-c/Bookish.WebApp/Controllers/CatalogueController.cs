using Azure.Identity;
using Bookish.WebApp.Data;
using Bookish.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow.CopyAnalysis;
using NuGet.Packaging;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;

namespace Bookish.WebApp.Controllers
{
    public class CatalogueController : Controller
    {
        BookishWebAppContext db; public CatalogueController()
        {
            db = new BookishWebAppContext();
        }

        public ActionResult Index()
        {
            var booksList = db.Books.ToList();

            return View(booksList);
        }

        public ActionResult NewBook()

        {
            return View();
        }

        [HttpPost]
        public IActionResult NewBook(string title, string author, string copies)

        {
            int copiesParsed = int.Parse(copies);
            var book = new Book
            {
                title = title,
                author = author,
                totalcopies = copiesParsed
            };
            db.Books.Add(book);
            db.SaveChanges();
            return View();
        }

        public ActionResult Details(int Id)
        {
            var bookInfo = new BookFullInfo();
            var bookAtId = db.Books.Where(s => s.isbn == Id).First<Book>();

            bookInfo.title = bookAtId.title;
            bookInfo.author = bookAtId.author;
            bookInfo.isbn = bookAtId.isbn;
            bookInfo.totalcopies = bookAtId.totalcopies;
            bookInfo.username = new List<string>();
            bookInfo.returndate = new List<string>();

            var listOfCopies = db.BorrowedBooks.Where(b => b.isbn == Id).ToList();
            List<string> dateList = new List<string>();
            List<string> usernameList = new List<string>();

            foreach (var copy in listOfCopies)
            {
                dateList.Add(copy.returndate);
            }

            foreach (var copy in listOfCopies)
            {
                var userAtId = db.Users.Where(u => u.userid == copy.userid).First<User>();
                usernameList.Add(userAtId.username);
            }

            bookInfo.returndate.AddRange(dateList);
            bookInfo.username.AddRange(usernameList);

            return View(bookInfo);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}