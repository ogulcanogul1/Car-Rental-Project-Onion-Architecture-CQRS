using App.Dtos.BlogDtos;
using App.WebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace App.WebUI.ViewComponents.BlogViewComponents.BlogDetails
{
    public class _BlogDetailsAuthorAboutComponentPartial : ViewComponent
    {
        private readonly BlogService _blogService;

        public _BlogDetailsAuthorAboutComponentPartial(BlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int blogId)
        { 
            HttpResponseMessage responseMessage = await _blogService.GetAuthorDetailByBlogIdAsync(blogId);
            if(responseMessage.IsSuccessStatusCode)
            {
                string jsonData = await responseMessage.Content.ReadAsStringAsync();
                AuthorDescriptionByBlogIdDto? dto = JsonConvert.DeserializeObject<AuthorDescriptionByBlogIdDto>(jsonData);
                return View(dto);
            }
            return View();
        }
    }
}
