using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using The_cool_Library.Data;
using The_cool_Library.Models;

namespace The_cool_Library.Controllers
{
    public class GenreController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;

        public GenreController (ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        //------------------------------------------------------------------------------------------------

        public IActionResult Index()
        {
            return View(applicationDbContext.Categories.ToList());
        }

        //-------------------------------------------------------------------------------------------------

        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            } else
            {
                applicationDbContext.Categories.Remove( applicationDbContext.Categories.Find(id));
                applicationDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        //-------------------------------------------------------------------------------------------------

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Genre genre)
        {
            if (ModelState.IsValid)
            {
                applicationDbContext.Categories.Add(genre);
                applicationDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(genre);
            }
        }

        //--------------------------------------------------------------------------------------------------------

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(applicationDbContext.Categories.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Genre genre)
        {
            if (ModelState.IsValid)
            {
                applicationDbContext.Categories.Update(genre);
                applicationDbContext.SaveChanges();
                return RedirectToAction("Index");
            } else
            {
                return View (genre);
            }
        }

        //----------------------------------------------------------------------------------
    }
}
