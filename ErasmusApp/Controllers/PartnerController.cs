using ErasmusApp.Data;
using ErasmusApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErasmusApp.Controllers
{
    public class PartnerController : Controller
    {
        private readonly ErasmusDb db = new ErasmusDb();
        // GET: Partner
        public ActionResult Index()
        {
            List<Partner> partners = db.Partners.ToList();
            ViewBag.Settings = db.Settings.FirstOrDefault();
            return View(partners);
        }
    }
}