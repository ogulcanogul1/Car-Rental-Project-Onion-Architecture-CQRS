﻿using Microsoft.AspNetCore.Mvc;

namespace App.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
