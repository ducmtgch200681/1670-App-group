using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Dynamic;
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
            bookDetail.IUs = context.IUs.ToList();
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

        public IActionResult SortPrice()
        {
            dynamic bookSortPrice = new ExpandoObject();
            bookSortPrice.Genres = context.Genres.ToList();
            bookSortPrice.Books = context.Books.OrderByDescending(p => p.Book_price).ToList();
            return View("Book", bookSortPrice);
        }

        public IActionResult SortName()
        {
            dynamic bookSortName = new ExpandoObject();
            bookSortName.Genres = context.Genres.ToList();
            bookSortName.Books = context.Books.OrderByDescending(n => n.Book_name).ToList();
            return View("Book", bookSortName);
        }

        //--------------------------------------------------------------------------------

        [Authorize(Roles = "Customer")]
        [HttpPost]
        public IActionResult OrderBook(int id, double price, int quantity, Book book)
        {
            var order = new Order();
            order.BookId = id;
            order.OrderDate = DateTime.Now.Date;
            order.Quantity = quantity;
            order.Price = price;
            order.Bill = order.Price * quantity;
            order.Email = User.Identity.Name;

            book = context.Books.Where(b => b.Id == id).FirstOrDefault();
            book.Book_quantity -= quantity;
            //book = context.Books.Find(id);
            context.Books.Update(book);

            context.Orders.Add(order);
            context.SaveChanges();
            return RedirectToAction("OrderList"); //lm bang hien thi list sach da mua sau
        }

        //--------------------------------------------------------------------------------

        [Authorize(Roles = "Customer")]
        public IActionResult OrderList()
        {
            
            dynamic orders = new ExpandoObject();
            orders.Genres = context.Genres.ToList();
            orders.Books = context.Books.ToList();
            orders.Orders = context.Orders.Include(b => b.Book)
                                          .Where(b => b.BookId == b.Book.Id)
                                          .ToList();
            orders.Orders = context.Orders.Where(p => p.Email.Contains(User.Identity.Name)).ToList();

            return View(orders);
        }

        //--------------------------------------------------------------------------------



    }

}
