using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InfoTrackWebApp.Models
{
    public class SEOForm
    {
        [Required(ErrorMessage = "Please enter a URL")]
        public string Url { get; set; }
        [Required(ErrorMessage = "Please enter some keywords")]
        public string Keywords { get; set; }
    }
}
