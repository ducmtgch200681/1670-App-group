﻿using Microsoft.AspNetCore.Mvc;
using The_cool_Library.Models; //cho chac - DMT

namespace The_cool_Library.Controllers
{
    public class AdminController : Controller
    {
        [Route ("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}