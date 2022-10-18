using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using The_cool_Library.Data;
using The_cool_Library.Models;

namespace The_cool_Library.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;

        public BookController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        //-------------------------------------------------------------
        public IActionResult Index()
        {
            return View(applicationDbContext.Books.ToList());
        }

        //-----------------------------------------------------------------
        public IActionResult Detail(int id)
        {
            //phần này lm sau khi đã tạo xong FK category
            return View(applicationDbContext.Books.Include(b => b.Category).FirstOrDefault(b => b.Book_id == id));
        }

        //----------------------------------------------------------------
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var book = applicationDbContext.Books.Find(id);
                applicationDbContext.Books.Remove(book);
                applicationDbContext.SaveChanges();
                TempData["Message"] = "Delete successfully";
                return RedirectToAction("Index");
            }
        }

        //----------------------------------------------------------------
        [HttpPost]        
        public IActionResult Add(Book book)
        {
            if(ModelState.IsValid)
            {
                applicationDbContext.Books.Add(book);
                applicationDbContext.SaveChanges();
                return RedirectToAction("Index");
            } else
            {
                return View(book);
            }
        }

        [HttpGet]
        public IActionResult Add()
        {
            var categories = applicationDbContext.Categories.ToList();
            ViewBag.Categories = categories;
            return View();
        }

        //-------------------------------------------------------------------------------
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if(ModelState.IsValid)
            {
                applicationDbContext.Books.Update(book);
                applicationDbContext.SaveChanges();
                return RedirectToAction("Index");
            } else
            {
                return View(book);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var categories = applicationDbContext.Categories.ToList();
            ViewBag.Category = categories;
            return View(applicationDbContext.Books.Find(id));
        }
    }
}
