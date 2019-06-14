using ErasmusApp.Data;
using ErasmusApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErasmusApp.Controllers
{
    public class AboutController:Controller
    {
        private readonly ErasmusDb db = new ErasmusDb();

        public ActionResult Index()
        {
            List<About> abouts = db.Abouts.ToList();
            ViewBag.Settings = db.Settings.FirstOrDefault();
            return View(abouts);
        }
    }
}