using Microsoft.AspNetCore.Mvc;

namespace App.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _LoaderUILayoutPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
