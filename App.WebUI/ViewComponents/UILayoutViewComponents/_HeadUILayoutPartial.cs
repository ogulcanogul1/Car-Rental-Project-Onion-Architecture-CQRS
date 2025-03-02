using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

namespace App.WebUI.ViewComponents.UILayoutViewComponents;

public class _HeadUILayoutPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
