using Microsoft.AspNetCore.Mvc;

namespace Introduction.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
