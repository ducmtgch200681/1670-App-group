﻿using Microsoft.AspNetCore.Mvc;
using System.Linq;
using The_cool_Library.Data;
using The_cool_Library.Models; //cho chac - DMT

namespace The_cool_Library.Controllers
{
    public class CustomerController : Controller
    {
        //private readonly ApplicationDbContext context;

        //public CustomerController(ApplicationDbContext context)
        //{
        //    this.context = context;
        //}

        public IActionResult Homepage()
        {
            return View();
        }
    }
}