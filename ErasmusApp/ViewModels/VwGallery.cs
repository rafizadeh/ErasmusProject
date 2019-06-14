using ErasmusApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ErasmusApp.ViewModels
{
    public class VwGallery
    {
        public List<Gallery> Galleries { get; set; }
        public List<GalleryPhoto> GalleryPhotos { get; set; }
    }
}