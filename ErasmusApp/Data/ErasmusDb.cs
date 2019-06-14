using ErasmusApp.Areas.Admin.Models;
using ErasmusApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ErasmusApp.Data
{
    public class ErasmusDb:DbContext
    {
        public ErasmusDb() : base("mydb") { }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<GalleryPhoto> GalleryPhotos { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}