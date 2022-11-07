using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Dynamic;
using System.Linq;
using The_cool_Library.Data;
using The_cool_Library.Models;

namespace The_cool_Library.Controllers
{
    [Authorize(Roles = "StoreOwner")]   
    public class StoreOwnerController : Controller
    {
        private readonly ApplicationDbContext context;

        public StoreOwnerController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //-------------------------------------------------------------------------------------

        public IActionResult Book()
        {
            dynamic indexgenre = new ExpandoObject();
            indexgenre.Genres = context.Genres.ToList();
            indexgenre.Books = context.Books.OrderByDescending(p => p.Id).ToList();
            return View(indexgenre);
        }

        //-------------------------------------------------------------------------------------

        public IActionResult BookDetail(int id)
        {
            var book = context.Books
                              .Include(b => b.Genre)
                              .FirstOrDefault(b => b.Id == id);
            return View(book);
        }

        //----------------------------------------------------------------------------------------

        public IActionResult BookSameGenre(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var book = context.Genres
                                     .Include(b => b.Books)
                                    .FirstOrDefault(b => b.Id == id);
                return View(book);

            }
        }

        //----------------------------------------------------------------------------------------

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                context.Books.Remove(context.Books.Find(id));
                context.SaveChanges();
                return RedirectToAction("Book");
            }
        }

        //------------------------------------------------------------------------------------------

        [HttpGet]
        public IActionResult AddBook()
        {
            var genres = context.Genres.ToList();
            ViewBag.Genres = genres;
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Books.Add(book);
                context.SaveChanges();
                return RedirectToAction("Book");
            }
            else
            {
                ViewBag.Genres = context.Genres.ToList(); ;
                return View(book);
            }
        }

        //---------------------------------------------------------------------------------------------

        [HttpGet]
        public IActionResult EditBook(int id)
        {
            var genres = context.Genres.ToList();
            ViewBag.Genres = genres;

            var book = context.Books.Where(b => b.Id == id).FirstOrDefault();

            return View(book);
        }

        [HttpPost]
        public IActionResult EditBook(Book book)
        {
            if (ModelState.IsValid)
            {


                context.Books.Update(book);
                context.SaveChanges();
                return RedirectToAction("Book");
            }
            else
            {
                ViewBag.Genres = context.Genres.ToList();
                return View(book);
            }
        }

        //---------------------------------------------------------------------------------------------

        public IActionResult Genre()
        {
            dynamic GenreCRUD = new ExpandoObject();
            GenreCRUD.Genres = context.Genres.ToList();
            GenreCRUD.GenreRequests = context.GenreRequests.ToList();

            return View(GenreCRUD);
        }

        //---------------------------------------------------------------------------------------------

        [HttpGet]
        public IActionResult EditGenre(int id)
        {
            return View(context.Genres.Find(id));
        }

        [Authorize(Roles = "StoreOwner")]
        [HttpPost]
        public IActionResult EditGenre(Genre genre)
        {
            if (ModelState.IsValid)
            {
                context.Genres.Update(genre);
                context.SaveChanges();
                return RedirectToAction("Genre");
            }
            else
            {
                return View(genre);
            }
        }

        //---------------------------------------------------------------------------------------------

        [HttpGet]
        public IActionResult MakeRequest()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MakeRequest(GenreRequest request)
        {
            if (ModelState.IsValid)
            {
                context.Add(request);
                context.SaveChanges();
                TempData["Message"] = "Request new genre";
                return RedirectToAction("MakeRequest");
            }
            else
            {
                return View(request);
            }
        }

        //--------------------------------------------------------------------------------

        public IActionResult Order()
        {
            var orders = context.Orders.Include(b => b.Book)
                                          .Where(b => b.BookId == b.Book.Id)
                                          .ToList();
            return View(orders);
        }



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
            bookSortPrice.Books = context.Books.OrderBy(p => p.Book_price).ToList();
            return View("Book", bookSortPrice);
        }
    }
}
