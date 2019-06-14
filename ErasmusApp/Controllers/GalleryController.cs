using ErasmusApp.Data;
using ErasmusApp.Models;
using ErasmusApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErasmusApp.Controllers
{
    public class GalleryController : Controller
    {
        private readonly ErasmusDb db = new ErasmusDb();
        // GET: Gallery
        public ActionResult Index()
        {
            List<Gallery> galleries = db.Galleries.ToList();
            List<GalleryPhoto> galleryPhotos = db.GalleryPhotos.ToList();


            VwGallery viewGallery = new VwGallery()
            {
                GalleryPhotos = galleryPhotos,
                Galleries = galleries
            };

            ViewBag.Settings = db.Settings.FirstOrDefault();
            return View(viewGallery);
        }
    }
}