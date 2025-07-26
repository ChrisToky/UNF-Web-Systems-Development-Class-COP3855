using Microsoft.AspNetCore.Mvc;

namespace StudentMS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
