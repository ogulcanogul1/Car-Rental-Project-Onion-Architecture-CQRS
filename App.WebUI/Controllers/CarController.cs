﻿using Microsoft.AspNetCore.Mvc;

namespace App.WebUI.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
