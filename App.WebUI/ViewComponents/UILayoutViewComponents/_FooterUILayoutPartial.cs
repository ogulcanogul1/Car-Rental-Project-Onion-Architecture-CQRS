using Microsoft.AspNetCore.Mvc;

namespace App.WebUI.ViewComponents.UILayoutViewComponents;

public class _FooterUILayoutPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
