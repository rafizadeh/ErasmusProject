using ErasmusApp.Data;
using ErasmusApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErasmusApp.Controllers
{
    public class BlogController : Controller
    {
        private readonly ErasmusDb db = new ErasmusDb();
        // GET: Blog
        public ActionResult Index()
        {
            List<Blog> blogs = db.Blogs.ToList();
            ViewBag.Settings = db.Settings.FirstOrDefault();
            return View(blogs);
        }

        public ActionResult BlogDetail(int id,string slug)
        {
            Blog blog = db.Blogs
                                .Where(b => b.Id == id && b.Slug == slug)
                                        .FirstOrDefault();


            ViewBag.Settings = db.Settings.FirstOrDefault();
            return View(blog);
        }
    }
}