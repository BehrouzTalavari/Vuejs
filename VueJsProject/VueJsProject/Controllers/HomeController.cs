﻿using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;

using VueJsProject.Models;

namespace VueJsProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }      
        public IActionResult Animation()
        {
            return View();
        }   
        
        public IActionResult FlipCards()
        {
            return View();
        }   
        
        public IActionResult FlipCardsByClick()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}