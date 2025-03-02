using Microsoft.AspNetCore.Mvc;

namespace App.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.data1 = "Hakkımızda";
            ViewBag.data2 = "Vizyonumuz & Misyonumuz";
            return View();
        }
    }
}
