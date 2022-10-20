﻿using Microsoft.AspNetCore.Mvc;
using System.Linq;
using The_cool_Library.Data;
using The_cool_Library.Models; //cho chac - DMT

namespace The_cool_Library.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext context;

        public CustomerController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        //[HttpGet]
        //public IActionResult Register()
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult Add(Customer customer)
        {
            //kiểm tra thông tin nhập vào từ form
            if (ModelState.IsValid)
            {
                //nếu hợp lệ thì add vào db
                context.Customers.Add(customer);
                //lưu thay đổi vào db
                context.SaveChanges();
                //return về trang index
                return RedirectToAction("Index");
                //return RedirectToAction(nameof(Index));
            }
            //nếu không hợp lệ thì quay ngược về form 
            return View(customer);
        }
    }
}
