using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ErasmusApp.Models
{
    public class GalleryPhoto
    {
        public int Id { get; set; }
        public Gallery Gallery { get; set; }
        public int GalleryId { get; set; }
        public string Path { get; set; }
    }
}