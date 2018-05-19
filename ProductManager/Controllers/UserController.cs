using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProductManager.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Your Login Page";

            return View();
        }
    }
}