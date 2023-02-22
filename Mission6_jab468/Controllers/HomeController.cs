using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private blahContext daContext { get; set; }

        public HomeController(blahContext someName)
        {
            daContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories = daContext.Categories.ToList();
            //return View("MovieForm");
            return View();
        }
        [HttpPost]
        public IActionResult MovieForm(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                daContext.Add(ar);
                daContext.SaveChanges();
                return View("confirm", ar);
            }
            else
            {
                ViewBag.Categories = daContext.Categories.ToList();
                return View();
            }
        }
        public IActionResult Display()
        {
            var applications = daContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();
            return View(applications);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = daContext.Categories.ToList();
            var form = daContext.Responses.Single(x => x.MovieID == movieid);
            return View("MovieForm", form);
        }
        [HttpPost]
        public IActionResult Edit (ApplicationResponse response)
        {
            daContext.Update(response);
            daContext.SaveChanges();
            return RedirectToAction("Display");
        }
        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var form = daContext.Responses.Single(x => x.MovieID == movieid);
            //ViewBag.Categories = daContext.Categories.ToList();
            return View(form);
        }
        [HttpPost]
        public IActionResult Delete (ApplicationResponse ar)
        {
            daContext.Responses.Remove(ar);
            daContext.SaveChanges();
            return RedirectToAction("Display");
        }
    }
}
