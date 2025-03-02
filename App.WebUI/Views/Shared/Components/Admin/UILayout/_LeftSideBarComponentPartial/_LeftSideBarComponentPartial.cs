using App.WebUI.ViewComponentUrlConfiguration;
using Microsoft.AspNetCore.Mvc;

namespace App.WebUI.Views.Shared.Components.Admin.UILayout._LeftSideBar
{
    public class _LeftSideBarComponentPartial : ViewComponent
    {
        private readonly string folderName = "_LeftSideBarComponentPartial";
        public IViewComponentResult Invoke()
        {
            return View(AdminUrlConfiguration._UILayout + folderName + AdminUrlConfiguration._default);
        }
    }
}
