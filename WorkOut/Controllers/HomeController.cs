using Microsoft.AspNetCore.Mvc;

namespace WorkOut.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
