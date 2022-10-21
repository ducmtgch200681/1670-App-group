using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Detail(int? id)
        {
            if(id == null)
            {
                return NotFound();
            } else
            {
                return View
                    (
                    //applicationDbContext.StoreOwners.FirstOrDefault(so => so.So_id == id)
                    );
            }
        }

        //----------------------------------------------------------------------------------------

        //public IActionResult Delete(int? id)
        //{
        //    if(id == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        //applicationDbContext.StoreOwners.Remove(applicationDbContext.StoreOwners.Find(id));
        //        //applicationDbContext.SaveChanges();
        //        //return RedirectToAction("Index");
        //    }
        //}

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

        //[HttpGet]
        //public IActionResult Edit(int id)
        //{
        //    //var storeOwner = applicationDbContext.StoreOwners.Find(id);
        //    //return View(storeOwner);
        //}

        //[HttpPost]
        //public IActionResult Edit(StoreOwner storeOwner)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        //applicationDbContext.StoreOwners.Update(storeOwner);
        //        //applicationDbContext.SaveChanges();
        //        //return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        return View(storeOwner);
        //    }
        //}
    }
}
