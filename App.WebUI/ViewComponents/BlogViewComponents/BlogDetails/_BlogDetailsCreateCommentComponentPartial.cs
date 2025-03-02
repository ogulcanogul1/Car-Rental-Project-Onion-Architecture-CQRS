using Microsoft.AspNetCore.Mvc;

namespace App.WebUI.ViewComponents.BlogViewComponents.BlogDetails
{
    public class _BlogDetailsCreateCommentComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
