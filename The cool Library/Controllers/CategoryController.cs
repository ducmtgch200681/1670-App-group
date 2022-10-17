using Microsoft.AspNetCore.Mvc;
using System.Linq;
using The_cool_Library.Data;
using The_cool_Library.Models;

namespace The_cool_Library.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;

        public CategoryController (ApplicationDbContext applicationDbContext)
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
        [HttpPost]
        public IActionResult Add(Category category)
        {
            if (ModelState.IsValid)
            {
                applicationDbContext.Categories.Add(category);
                applicationDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(category);
            }
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        //--------------------------------------------------------------------------------------------------------
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                applicationDbContext.Categories.Update(category);
                applicationDbContext.SaveChanges();
                return RedirectToAction("Index");
            } else
            {
                return View (category);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(applicationDbContext.Categories.Find(id));
        }
    }
}
