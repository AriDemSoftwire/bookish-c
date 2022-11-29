using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookish.Web.Controllers
{
    public class CatalogueController : Controller
    {
        public ActionResult Catalogue()
        {
            ViewBag.Message = "The book catalogue.";

            return View();
        }
    }