using Microsoft.AspNetCore.Mvc;

namespace App.WebUI.ViewComponents.BlogViewComponents.BlogDetails
{
    public class _BlogDetailsSideBarSearchBoxComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
