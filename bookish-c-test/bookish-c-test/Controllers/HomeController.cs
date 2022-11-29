using bookish_c_test.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using bookish_c_test.Connection;
using System.Collections;
using System.Linq;
using System.Web;
using System;


namespace bookish_c_test.Controllers
{
    public class HomeController : Controller
    {
        TestDbContext db; public HomeController()
        {
            db = new TestDbContext();
        }

        public IActionResult Index()
        {
            var data = db.Book.ToList();
            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}