﻿using System.Web.Mvc;

namespace ExampleWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Views/Home.cshtml");
        }
    }
}
