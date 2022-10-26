using Microsoft.AspNetCore.Authorization;
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
            dynamic indexgenre = new ExpandoObject();
            indexgenre.Genres = context.Genres.ToList();
            indexgenre.Books = context.Books.ToList();
            return View(indexgenre);
        }

        //-----------------------------------------------------------------------------------

        public IActionResult Book()
        {
            dynamic allBookwithGenre = new ExpandoObject();
            allBookwithGenre.Genres = context.Genres.ToList();
            allBookwithGenre.Books = context.Books.ToList();
            return View(allBookwithGenre);
        }

        public IActionResult BookDetail(int id)
        {
            dynamic bookDetail = new ExpandoObject();
            bookDetail.Genres = context.Genres.ToList();
            bookDetail.Books = context.Books.Include(b => b.Genre)
                                            .FirstOrDefault(b => b.Id == id);
            return View(bookDetail);
        }

        //-----------------------------------------------------------------------------------

        [HttpGet]
        public IActionResult GenrePage(int id)
        {
            dynamic allBookofGenre = new ExpandoObject();
            allBookofGenre.Genres = context.Genres.ToList();
            allBookofGenre.Books = context.Books.Where(g => g.GenreId == id).ToList();

            return View(allBookofGenre);
        }


        //-----------------------------------------------------------------------------------

        public IActionResult About()
        {
            dynamic aboutgenre = new ExpandoObject();
            aboutgenre.Genres = context.Genres.ToList();
            aboutgenre.Books = context.Books.ToList();
            return View(aboutgenre);
        }

        public IActionResult Feedback()
        {
            return View();
        }
        
        public IActionResult ContactUs()
        {
            return View();
        }

        //--------------------------------------------------------------------------------

        [HttpPost]
        public IActionResult Search(string key)
        {
            dynamic bookSearch = new ExpandoObject();
            bookSearch.Genres = context.Genres.ToList();
            bookSearch.Books = context.Books.Where(p => p.Book_name.Contains(key)).ToList();
            
            if (bookSearch.Books.Count == 0)
            {
                TempData["Message"] = "You can't find any Books !";
            }
            return View("Book", bookSearch);
        }

        public IActionResult Sort()
        {
            dynamic bookSort = new ExpandoObject();
            bookSort.Genres = context.Genres.ToList();
            bookSort.Books = context.Books.OrderByDescending(p => p.Book_price).ToList();
            return View("Book", bookSort);
        }

        //--------------------------------------------------------------------------------

        [Authorize(Roles = "Customer")]
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

        [Authorize(Roles = "Customer")]
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

        [Authorize(Roles = "Customer")]
        public IActionResult OrderList()
        {
            var orders = context.Orders.ToList();
            return View(orders);
        }

        //--------------------------------------------------------------------------------


        
    }

}
