using Microsoft.AspNetCore.Mvc;

namespace Empty_Asp.Net.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
