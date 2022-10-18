using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
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

        public IActionResult Index()
        {
            var universities = context.Admins.ToList();
            return View(universities);
        }

        //public IActionResult Info(int? id)
        //{
        //    //if (id == null)
        //    //{
        //    //    return NotFound();
        //    //}
        //    //var university = context.Admins
        //    //                        .Include(u => u.Students)
        //    //                        .FirstOrDefault(u => u.Id == id);

        //    //Note: khi muốn truy xuất dữ liệu của bảng B từ bảng A
        //    //thì cần sử dụng Include kết hợp với FirstOrDefault
        //    //còn nếu chỉ truy xuất thông tin id đơn thuần thì sử dụng
        //    //Find hoặc FirstOrDefault đều được

        //    //return View(university);
        //}

        public IActionResult Remove(int id)
        {
            var admin = context.Admins.Find(id);
            context.Admins.Remove(admin);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

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
        public IActionResult Edit(int id)
        {
            var university = context.Admins.Find(id);
            return View(university);
        }

        [HttpPost]
        public IActionResult Edit(Admin admin)
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
                TempData["Message"] = "Delete student successfully !";

                //return
                return RedirectToAction("Index");
            }
        }
    }
}
