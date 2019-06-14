using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ErasmusApp.Models
{
    public class Partner
    {
        public int Id{ get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Photo { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Address { get; set; }
        public string WebSite { get; set; }
    }
}