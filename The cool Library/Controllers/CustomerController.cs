using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Dynamic;
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
            var genre = context.Genres.ToList();
            return View(genre);
        }
        
        public IActionResult Book()
        {
            dynamic allBookwithGenre = new ExpandoObject();
            allBookwithGenre.Genres = context.Genres.ToList();
            allBookwithGenre.Books = context.Books.ToList();
            return View(allBookwithGenre);
        }

        public IActionResult BookDetail(int id)
        {
            var book = context.Books
                              .Include(b => b.Genre)
                              .FirstOrDefault(b => b.Id == id);
            return View(book);
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
            return RedirectToAction("OrderList"); //lm bang hien thi list sach da mua sau
        }

        //--------------------------------------------------------------------------------

        public IActionResult OrderList()
        {
            var orders = context.Orders.ToList();
            return View(orders);
        }

        //--------------------------------------------------------------------------------

        [HttpGet]
            public IActionResult GenrePage(int id)
            {
                dynamic allBookofGenre = new ExpandoObject();
                //allBookofGenre.Genres = context.Genres.Where(g => g.Id == id).FirstOrDefault();
                allBookofGenre.Genres = context.Genres.ToList();
                allBookofGenre.Books = context.Books.Where(g => g.GenreId == id).ToList();

                return View(allBookofGenre);
            }


        //-----------------------------------------------------------------------------------
        public IActionResult Sort()
        {
            var products = context.Books.OrderByDescending(p => p.Book_price).ToList();
            return View("Book", products);
        }
    }

}
