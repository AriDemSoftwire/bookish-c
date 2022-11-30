using Bookish.WebApp.Data;
using Bookish.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
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
            var bookAtId = db.Books.Where(s => s.isbn == Id).FirstOrDefault<Book>();

            return View(bookAtId);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}