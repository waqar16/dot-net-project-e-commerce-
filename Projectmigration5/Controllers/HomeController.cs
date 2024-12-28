using Projectmigration5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projectmigration5.Controllers
{
    public class HomeController : Controller
    {
        KEWEntities db = new KEWEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Product()
        {
            return View();
        }

        public ActionResult Order()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult TermsandCondition()
        {
            return View();
        }

        public PartialViewResult pvProducts()
        {
            var lstproducts = (from d in db.Products select d).Take(5).ToList();
            return PartialView(lstproducts);
        }

        public PartialViewResult pvFProducts()
        {
            var lstFproducts = (from d in db.Products where d.isFeatured == true select d).Take(5).ToList();
            return PartialView(lstFproducts);
        }

    }
}