using Microsoft.AspNetCore.Mvc;
using System.Linq;
using The_cool_Library.Data;
using The_cool_Library.Models;

namespace The_cool_Library.Controllers
{
    public class GenreRequestController : Controller
    {
       
            private ApplicationDbContext context;
            public GenreRequestController(ApplicationDbContext context)
            {
                this.context = context;
            }

            //-------------------------------------------------------------------------

            public IActionResult Index()
            {
                return View(context.GenreRequests.ToList());
            }


            //-----------------------------------------------------------------------
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

            //------------------------------------------------------------------------------
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
