using App.WebUI.ViewComponentUrlConfiguration;
using Microsoft.AspNetCore.Mvc;

namespace App.WebUI.Views.Shared.Components.Admin.UILayout._ScriptsComponentPartial
{
    public class _ScriptsComponentPartial : ViewComponent
    {
        private readonly string folderName = "_ScriptsComponentPartial";
        public IViewComponentResult Invoke()
        {
            return View(AdminUrlConfiguration._UILayout + folderName + AdminUrlConfiguration._default);
        }
    }
}
