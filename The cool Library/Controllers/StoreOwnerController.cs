using Microsoft.AspNetCore.Mvc;
using System.Linq;
using The_cool_Library.Data;
using The_cool_Library.Models;

namespace The_cool_Library.Controllers
{
    public class StoreOwnerController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;

        public StoreOwnerController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        //-------------------------------------------------------------------------------------

        public IActionResult Book()
        {
            return View(applicationDbContext.Books.ToList());
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
        public IActionResult Add()
        {
            var genres = applicationDbContext.Books.ToList();
            ViewBag.Genres = genres;
            return View();
        }

        [HttpPost]
        public IActionResult Add(Book book)
        {
            if (ModelState.IsValid)
            {
                applicationDbContext.Books.Add(book);
                applicationDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
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
