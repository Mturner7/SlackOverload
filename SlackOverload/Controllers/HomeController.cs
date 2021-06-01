using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SlackOverload.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace SlackOverload.Controllers
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

        [HttpPost]
        public IActionResult Login(string username)
        {
            Regex userRgx = new Regex(@"([\w\d\!]){3,30}");

            if (username == null || !userRgx.IsMatch(username)) 
            { 
                return RedirectToAction("Index");
            }
            SlackData.CurrentUser = username;

            return RedirectToAction("Index", "Questions");
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
