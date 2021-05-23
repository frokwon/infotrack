using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using InfoTrack.Library.Helpers;
using InfoTrackWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace InfoTrackWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISEOHelper SEOHelper;

        public HomeController(ISEOHelper sEOHelper)
        {
            SEOHelper = sEOHelper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult SEOResults(SEOForm sEOForm)
        {
       
            if (ModelState.IsValid)
            {
                var results = new SEOResults
                {
                    Rankings = SEOHelper.GetRankings(sEOForm.Url, sEOForm.Keywords)
                };

                return View(results);
            }

            return View("Index");
        }
    }
}
