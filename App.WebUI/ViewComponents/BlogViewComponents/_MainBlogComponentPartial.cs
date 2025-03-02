using App.Dtos.BlogDtos;
using App.WebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace App.WebUI.ViewComponents.BlogViewComponents
{
    public class _MainBlogComponentPartial : ViewComponent
    {
        private readonly BlogService _blogService;

        public _MainBlogComponentPartial(BlogService blogService)
        {
            _blogService = blogService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            HttpResponseMessage responseMessage = await _blogService.GetAllBlogWithAuthorAsync();
            if(responseMessage.IsSuccessStatusCode)
            {
               string jsonData = await responseMessage.Content.ReadAsStringAsync();
                List<MainBlogResponseDto>? dto =  JsonConvert.DeserializeObject<List<MainBlogResponseDto>>(jsonData);
                return View(dto);
            }
            return View();
        }
    }
}
