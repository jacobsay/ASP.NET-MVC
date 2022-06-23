using Microsoft.AspNetCore.Mvc;
using System;

namespace Introduction.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View("~/Views/Home/Contacts.cshtml");
        }
    }
}
