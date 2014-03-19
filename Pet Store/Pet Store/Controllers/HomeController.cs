using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pet_Store.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "The following websites are cited:";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Manage()
        {
            ViewBag.Message = "Pet Management Control";

            return View();
        }

        public ActionResult Inventory()
        {
            ViewBag.Message = "Shop Inventory";

            return View();
        }
    }
}