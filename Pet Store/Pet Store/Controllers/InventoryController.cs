using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Pet_Store.Models;

namespace Pet_Store.Controllers
{
    public class InventoryController : Controller
    {
        private PetDBContext db = new PetDBContext();

        // GET: /Inventory/
        public ActionResult Index()
        {
            return View(db.Pets.ToList());
        }

        // GET: /Inventory/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pet pet = db.Pets.Find(id);
            if (pet == null)
            {
                return HttpNotFound();
            }
            return View(pet);
        }

    }
}
