using Microsoft.AspNetCore.Mvc;

namespace App.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _ScriptsUILayoutPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
