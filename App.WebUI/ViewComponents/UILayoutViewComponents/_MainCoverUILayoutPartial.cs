using Microsoft.AspNetCore.Mvc;

namespace App.WebUI.ViewComponents.UILayoutViewComponents
{
    public class _MainCoverUILayoutPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
