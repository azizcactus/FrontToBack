using Microsoft.AspNetCore.Mvc;

namespace FrontToBackPronia.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
