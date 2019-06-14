using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ErasmusApp.Models
{
    public class About
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public string DesignedDescription { get; set; }
        public string DesignedTitle { get; set; }
        [Required]
        public string ShortDesc { get; set; }
       
    }
}