using Microsoft.AspNetCore.Mvc;

namespace PartialView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
