using Microsoft.AspNetCore.Mvc;

namespace App.WebUI.ViewComponents.AboutViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
