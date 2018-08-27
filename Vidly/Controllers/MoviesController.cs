﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movies = new Movies() { Name = "Shrek!"};
            return View(movies);
            // Action Results
            // return Content("Hello World");
            // return HttpNotFound();
            // return new EmptyResult();
            // return RedirectToAction("Index", "Home", new{ page = 1, sortBy="name" });
        }
    }
}