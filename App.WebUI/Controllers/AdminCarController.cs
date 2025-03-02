using Microsoft.AspNetCore.Mvc;

namespace App.WebUI.Controllers
{
    public class AdminCarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
