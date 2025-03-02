using App.WebUI.ViewComponentUrlConfiguration;
using Microsoft.AspNetCore.Mvc;

namespace App.WebUI.Views.Shared.Components.Admin.UILayout.HeaderComponentPartial
{
    public class _HeaderComponentPartial : ViewComponent
    {
        private readonly string folderName = "_HeaderComponentPartial";
        public IViewComponentResult Invoke()
        {
            return View(AdminUrlConfiguration._UILayout + folderName + AdminUrlConfiguration._default);
        }
    }
}
