using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using The_cool_Library.Data;
using The_cool_Library.Models; //cho chac - DMT
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

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

        public IActionResult Book()
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
        
        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Search(string key)
        {
            var products = context.Books.Where(p => p.Book_name.Contains(key)).ToList();
            if (products.Count == 0)
            {
                TempData["Message"] = "You can't find any Books !";
            }
            return View("Book", products);
        }

        //--------------------------------------------------------------------------------
        [HttpGet]
        public IActionResult OrderBook(int id)
        {
            //DataCart();

            var book = context.Books.Find(id);
            ViewBag.Book_name = book.Book_name;
            ViewBag.Quantity = book.Book_quantity;
            ViewBag.Id = id;
            ViewBag.Price = book.Book_price;
            return View();
        }

        [HttpPost]
        public IActionResult OrderBook(Order order, double price)
        {
            order.OrderDate = DateTime.Now.Date;
            order.Price = price * order.Quantity;
            order.Id = context.Orders.ToList().Count + 1;
            context.Orders.Add(order);
            context.SaveChanges();
            return RedirectToAction(); //lm bang hien thi list sach da mua sau
        }
    }
}
