﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class MoviesController : Controller
    {
        //
        // GET: /Movie/
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Meu amigo" };
            return View(movie);
        }
	}
}