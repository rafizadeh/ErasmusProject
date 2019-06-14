using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ErasmusApp.Models
{
    public class Settings
    {
        public int Id { get; set; }
        [Required]
        public string Logo { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Facebook { get; set; }
        [Required]
        public string Twitter { get; set; }
        [Required]
        public string Lat { get; set; }
        [Required]
        public string Lang { get; set; }
        [Required]
        public string ShortDesc { get; set; }
    }
}