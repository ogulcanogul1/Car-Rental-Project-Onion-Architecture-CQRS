using Microsoft.AspNetCore.Mvc;

namespace App.WebUI.ViewComponents.AboutViewComponents
{
    public class _BecameADriverComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
