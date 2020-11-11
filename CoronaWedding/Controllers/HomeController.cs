using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoronaWedding.Models;
using CoronaWedding.Services;
using Microsoft.AspNetCore.Http;

namespace CoronaWedding.Controllers
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

        public IActionResult Comment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Comment(string comment)
        {
            if (HttpContext.Session.GetString("userId") != null)
            {
                Facbook.PostToPage(comment);
                return View();
            }
            return RedirectToAction("Login","Accounts");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
