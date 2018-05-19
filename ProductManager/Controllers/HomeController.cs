using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductManager.Models;

namespace ProductManager.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Orders()
        {
            ViewData["Message"] = "Your Orders Page";

            return View();
        }

        public IActionResult Completed()
        {
            ViewData["Message"] = "Your Completed Page";

            return View();
        }

        public IActionResult Archive()
        {
            ViewData["Message"] = "Your Archive Page";

            return View();
        }

        public IActionResult Analysis()
        {
            ViewData["Message"] = "Your Analysis Page";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
