using App.Dtos.BlogDtos;
using App.WebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace App.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogComponentPartial : ViewComponent
    {
        private readonly BlogService _service;

        public _BlogComponentPartial(BlogService service)
        {
            _service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            HttpResponseMessage responseMessage = await _service.GetDynamicBlogWithAuthor(false,3);

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
