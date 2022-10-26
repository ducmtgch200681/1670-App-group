using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using The_cool_Library.Data;
using The_cool_Library.Models; //cho chac - DMT

namespace The_cool_Library.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext context;

        public AdminController(ApplicationDbContext context)
        {
            this.context = context;
        }
        //-----------------------------------------------------------------

        [Route("/admin/index")]
        public IActionResult GenreRequest()
        {
            return View(context.GenreRequests.ToList());
        }

        //-----------------------------------------------------------------

        public IActionResult Accept(int id)
        {
            var request = context.GenreRequests.Find(id);
            request.Status = 1;
            context.GenreRequests.Update(request);
            context.SaveChanges();
            TempData["Genre"] = request.Name;
            return RedirectToAction("AddFromRequest");
        }

        public IActionResult Reject(int id)
        {
            var request = context.GenreRequests.Find(id);
            request.Status = -1;
            context.GenreRequests.Update(request);
            context.SaveChanges();
            TempData["Message"] = "Request is rejected";
            return RedirectToAction("GenreRequest");
        }

        //-----------------------------------------------------------------

        public IActionResult AddFromRequest()
        {
            Genre genre = new Genre();
            if (ModelState.IsValid)
            {
                genre.Genre_name = (string)TempData["Genre"];
                context.Add(genre);
                context.SaveChanges();
                TempData["Message"] = "Add new data successfully";
                return RedirectToAction("GenreRequest");
            }
            else
            {
                return RedirectToAction("GenreRequest");
            }
        }

    }
}
