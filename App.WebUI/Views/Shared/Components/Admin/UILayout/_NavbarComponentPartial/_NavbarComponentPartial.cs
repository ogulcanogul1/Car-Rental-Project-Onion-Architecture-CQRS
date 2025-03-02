using App.WebUI.ViewComponentUrlConfiguration;
using Microsoft.AspNetCore.Mvc;

namespace App.WebUI.Views.Shared.Components.Admin.UILayout._NavbarComponentPartial
{
    public class _NavbarComponentPartial : ViewComponent
    {
        private readonly string folderName = "_NavbarComponentPartial";

        public IViewComponentResult Invoke()
        {
            return View(AdminUrlConfiguration._UILayout + folderName + AdminUrlConfiguration._default);
        }
    }
}
