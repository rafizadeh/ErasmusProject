using ErasmusApp.Data;
using ErasmusApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErasmusApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly ErasmusDb db = new ErasmusDb();
        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.Settings = db.Settings.FirstOrDefault();
            Settings settings = db.Settings.FirstOrDefault();
            return View(settings);
        }
    }
}