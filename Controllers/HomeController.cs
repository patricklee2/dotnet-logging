﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dotnet_logging.Models;

namespace dotnet_logging.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Console.Error.WriteLine("requesting Index");
            return View();
        }

        public IActionResult Privacy()
        {
            Console.Error.WriteLine("requesting Privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
