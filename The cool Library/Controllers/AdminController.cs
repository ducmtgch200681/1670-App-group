using Microsoft.AspNetCore.Mvc;
using System.Linq;
using The_cool_Library.Data;
using The_cool_Library.Models; //cho chac - DMT

namespace The_cool_Library.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext context;

        public AdminController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //-----------------------------------------------------------------

        public IActionResult Index()
        {
            var admins = context.Admins.ToList();
            return View(admins);
        }

        //-----------------------------------------------------------------

        public IActionResult Info(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var admin = context.Admins.Find(id);

            return View(admin);
        }

        //-----------------------------------------------------------------

        //public IActionResult Remove(int id)
        //{
        //    var admin = context.Admins.Find(id);
        //    context.Admins.Remove(admin);
        //    context.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //--------------------------------------------------------

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Admin admin)
        {
            //check
            if (ModelState.IsValid)
            {
                context.Admins.Add(admin);
                //save
                context.SaveChanges();
                //return
                return RedirectToAction("Index");
            }
            return View(admin);
        }

        //--------------------------------------------------------

        [HttpGet]
        public IActionResult Update(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                var admin = context.Admins.Find(id);
                return View(admin);
            }

        }

        [HttpPost]
        public IActionResult Update(Admin admin)
        {
            //check
            if (ModelState.IsValid)
            {
                context.Admins.Update(admin);
                //save
                context.SaveChanges();
                //return
                return RedirectToAction("Index");
                //return RedirectToAction(nameof(Index));
            }
            return View(admin);
        }

        //-----------------------------------------------------------------

        //[Authorize(Roles = "Administrator")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                //check
                var admin = context.Admins.Find(id);
                //delete
                context.Admins.Remove(admin);
                //save
                context.SaveChanges();

                //notify with Tempdata if redirect
                TempData["Message"] = "Delete admin successfully !";

                //return
                return RedirectToAction("Index");
            }
        }
    }
}
