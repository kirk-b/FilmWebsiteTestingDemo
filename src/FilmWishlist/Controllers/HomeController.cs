﻿using System.Web.Mvc;

namespace FilmWishlist.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}