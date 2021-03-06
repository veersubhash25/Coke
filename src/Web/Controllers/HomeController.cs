﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return Content("Hello Friends This is Subhash");
        }
        public IActionResult ReturnJson()
        {
            return Json(new { name = "subhash", age = "22" });
        }
        public IActionResult ReturnHtml()
        {
            var index = "<!DOCTYPE HTML><html><head><title>Subhash Veeramachaneni</title></head><body>Welcome to c# app </body></html>";
            return Content(index,"text/html");
                
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
