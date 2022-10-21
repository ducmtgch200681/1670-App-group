using Microsoft.AspNetCore.Mvc;
using System.Linq;
using The_cool_Library.Data;
using The_cool_Library.Models; //cho chac - DMT

namespace The_cool_Library.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext context;

        public CustomerController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [Route("/")]
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult AllBook()
        {
            var allBook = context.Books.ToList();
            return View(allBook);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Feedback()
        {
            return View();
        }
        
    }
}
