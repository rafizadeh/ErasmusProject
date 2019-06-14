using ErasmusApp.Data;
using ErasmusApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErasmusApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ErasmusDb db = new ErasmusDb();

        public ActionResult Index()
        {
            VwHome viewHome = new VwHome()
            {
                Partners = db.Partners.ToList(),
                Blogs = db.Blogs.ToList(),
                Activities = db.Activities.ToList()
            };

            ViewBag.Settings = db.Settings.FirstOrDefault();
            return View(viewHome);
        }

    }
}