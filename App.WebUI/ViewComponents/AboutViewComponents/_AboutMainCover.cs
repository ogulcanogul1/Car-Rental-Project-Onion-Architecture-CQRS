using App.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace App.WebUI.ViewComponents.AboutViewComponents
{
    public class _AboutMainCover : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
