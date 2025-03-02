using App.Dtos.TagCloudDtos;
using App.WebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace App.WebUI.ViewComponents.BlogViewComponents.BlogDetails
{
    public class _BlogDetailsSideBarTagCloudComponentPartial : ViewComponent
    {
        private TagCloudService _tagCloudService;

        public _BlogDetailsSideBarTagCloudComponentPartial(TagCloudService tagCloudService)
        {
            _tagCloudService = tagCloudService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int blogId)
        {
            HttpResponseMessage responseMessage = await _tagCloudService.GetTagCloudByBlogId(blogId);

            if (responseMessage.IsSuccessStatusCode)
            {
                string jsonData = await responseMessage.Content.ReadAsStringAsync();
                List<TagCloudResponseDto>? dto = JsonConvert.DeserializeObject<List<TagCloudResponseDto>>(jsonData);
                return View(dto);
            }
            return View();
        }
    }
}
