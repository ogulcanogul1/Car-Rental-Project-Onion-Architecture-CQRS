using App.Dtos.BlogDtos;
using App.WebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace App.WebUI.ViewComponents.BlogViewComponents.BlogDetails
{
    public class _BlogDetailsSideBarRecentBlogComponentPartial : ViewComponent
    {
        private readonly BlogService _blogService;

        public _BlogDetailsSideBarRecentBlogComponentPartial(BlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            HttpResponseMessage responseMessage = await _blogService.GetDynamicBlogWithAuthor(false,3);
            if(responseMessage.IsSuccessStatusCode)
            {
                string jsonData = await responseMessage.Content.ReadAsStringAsync();
                List<BlogResponseDto>? dto = JsonConvert.DeserializeObject<List<BlogResponseDto>>(jsonData);
                return View(dto);
            }
            return View();
        }
    }
}
