using Microsoft.AspNetCore.Mvc;

namespace App.WebUI.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.data1 = "Hizmetler";
            ViewBag.data2 = "Hizmetlerimiz";
            return View();
        }
    }
}
