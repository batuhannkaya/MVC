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
            ViewData["NAME"] = "BATUHAN";
            ViewBag.SURNAME = "KAYA";
            TempData["AGE"] = "17";

            return View();
        }
         public ActionResult Kitap()
         {
            Kitap k = new Kitap();
            k.SeriNo = 97897;
            k.KitapAdi = "Kürk Mantolu Madonna";
            k.Yaş = 17;
            k.YazarAdi = "Sabahattin Ali";


            return View(k);

         }
        public ActionResult Login()
        {
        

            return View();
        }
    }
}