using Microsoft.AspNetCore.Mvc;

namespace App.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
