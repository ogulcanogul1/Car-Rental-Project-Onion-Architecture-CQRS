using App.WebUI.ViewComponentUrlConfiguration;
using Microsoft.AspNetCore.Mvc;

namespace App.WebUI.Views.Shared.Components.Admin.UILayout._FooterComponentPartial
{
    public class _FooterComponentPartial : ViewComponent
    {
        private readonly string folderName = "_FooterComponentPartial";
        public IViewComponentResult Invoke()
        {
            return View(AdminUrlConfiguration._UILayout + folderName + AdminUrlConfiguration._default);
        }
    }
}
