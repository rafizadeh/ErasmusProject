using ErasmusApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ErasmusApp.ViewModels
{
    public class VwHome
    {
        public List<Partner> Partners { get; set; }
        public List<Activity> Activities { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}