using LibraryHOLTest1Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryHOLTest1Web.Controllers
{
    public class StoreController : Controller
    {
        LibraryEntities libDB = new LibraryEntities();
        // GET: Store
        public ActionResult Index()
        {
            var cat = libDB.Categories.ToList();
            return View(cat);
        }
    }
}