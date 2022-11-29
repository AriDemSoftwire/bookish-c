﻿using Bookish.WebApp.Data;
using Bookish.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bookish.WebApp.Controllers
{
    public class HomeController : Controller
    {
        BookishWebAppContext db; public HomeController()
        {
            db = new BookishWebAppContext();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ActionResult Catalogue()
        {
            var data = db.Book.ToList();
            return View(data);
        }
        public ActionResult About()
        {

            return View();
        }
        public ActionResult Contact()
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