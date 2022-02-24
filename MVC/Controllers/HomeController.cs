﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        //GET: Home
        public ActionResult Index()
        {
            ViewData["NAME"] = "Batuhan";
            ViewBag.SURNAME = "Kaya";
            TempData["AGE"] = "17";

            return View();
        }
        public ActionResult Login()
        {
            ViewData["Pencere"] = "Window";
            ViewBag.bed = "Yatak";
            TempData["ad"] = "Gizem";

            return View();
        }

    }
}