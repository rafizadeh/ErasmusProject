using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ErasmusApp.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ShortDesc { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Photo { get; set; }
        [Required]
        public string Slug { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}