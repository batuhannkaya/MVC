using MVC.Models;
using System;
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
         public ActionResult Kitap()
         {
            Kitap k = new Kitap();
            k.SeriNo = 97897;
            k.KitapAdi = "Kürk Mantolu Madonna";
            k.Yaş = 1998;
            k.YazarAdi = "Sabahattin Ali";


            return View(k);
         }
    }
}