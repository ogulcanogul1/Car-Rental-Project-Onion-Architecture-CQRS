using App.Dtos.BlogDtos;
using App.WebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace App.WebUI.ViewComponents.BlogViewComponents.BlogDetails
{
    public class _BlogDetailsMainContentComponentPartial : ViewComponent
    {
        private readonly BlogService _blogService;

        public _BlogDetailsMainContentComponentPartial(BlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            HttpResponseMessage responseMessage = await _blogService.GetBlogByIdAsync(id);
            if (responseMessage.IsSuccessStatusCode) 
            {
                string jsonData = await responseMessage.Content.ReadAsStringAsync();
                BlogByIdResponseDto? dto = JsonConvert.DeserializeObject<BlogByIdResponseDto>(jsonData);
                return View(dto);
            }
            return View();
        }
    }
}
