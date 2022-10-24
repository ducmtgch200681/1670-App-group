using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using The_cool_Library.Data;
using The_cool_Library.Models;

namespace The_cool_Library.Controllers
{
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
            return View(context.Books.ToList());
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

        public IActionResult GenreRequest()
        {
            return View(context.GenreRequests.ToList());
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

        //---------------------------------------------------------------------------------------------

        public IActionResult Accept(int id)
        {
            var request = context.GenreRequests.Find(id);
            request.Status = 1;
            context.GenreRequests.Update(request);
            context.SaveChanges();
            TempData["Genre"] = request.Name;
            return RedirectToAction("AddFromRequest", "Genre");
        }

        public IActionResult Reject(int id)
        {
            var request = context.GenreRequests.Find(id);
            request.Status = -1;
            context.GenreRequests.Update(request);
            context.SaveChanges();
            TempData["Message"] = "Request is rejected";
            return RedirectToAction("Index");
        }
    }
}
