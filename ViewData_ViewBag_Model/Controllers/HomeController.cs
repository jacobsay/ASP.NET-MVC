using Microsoft.AspNetCore.Mvc;
using ViewData_ViewBag_Model.Models;

namespace ViewData_ViewBag_Model.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["User"] = new User("Greed", 30);
            return View();
        }

        [ActionName("ViewBag")]
        public IActionResult GetViewBag()
        {
            ViewBag.User = new User("Greed", 30);
            return View();
        }

        [ActionName("Model")]
        public IActionResult GetModel()
        {
            return View(new User("Greed", 30));
        }
    }
}
