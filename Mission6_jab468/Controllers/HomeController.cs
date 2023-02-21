using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission6_jab468.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_jab468.Controllers
{
    public class HomeController : Controller
    {
        private blahContext _blahContext { get; set; }

        public HomeController(blahContext someName)
        {
            _blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MovieForm()
        {
            //return View("MovieForm");
            return View();
        }
        [HttpPost]
        public IActionResult MovieForm(ApplicationResponse ar)
        {
            _blahContext.Add(ar);
            _blahContext.SaveChanges();
            return View("confirm", ar);
        }
    }
}
