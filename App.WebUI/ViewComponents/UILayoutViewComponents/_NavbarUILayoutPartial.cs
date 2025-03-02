using Microsoft.AspNetCore.Mvc;

namespace App.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _NavbarUILayoutPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
