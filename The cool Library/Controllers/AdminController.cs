using Microsoft.AspNetCore.Mvc;

namespace The_cool_Library.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
