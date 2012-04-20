using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechFest.Backbone.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {         
            return View();
        }

        public ActionResult SingleBook()
        {
            var db = new TechFest.Backbone.Models.BooksEntities();
            return View(db.Books.First());
        }

        public ActionResult BookCollection()
        {
            var db = new TechFest.Backbone.Models.BooksEntities();
            return View(db.Books);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
