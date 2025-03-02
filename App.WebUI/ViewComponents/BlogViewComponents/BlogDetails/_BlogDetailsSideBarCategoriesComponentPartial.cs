using App.Dtos.CategoryDtos;
using App.WebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace App.WebUI.ViewComponents.BlogViewComponents.BlogDetails
{
    public class _BlogDetailsSideBarCategoriesComponentPartial : ViewComponent
    {
        private readonly CategoryService _categoryService;

        public _BlogDetailsSideBarCategoriesComponentPartial(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            HttpResponseMessage responseMessage =  await _categoryService.GetCategories();
            
            if(responseMessage.IsSuccessStatusCode)
            {
                string jsonData = await responseMessage.Content.ReadAsStringAsync();
                List<GroupByCategoryNameBlogCountDto>? dto = JsonConvert.DeserializeObject<List<GroupByCategoryNameBlogCountDto>>(jsonData);
                return View(dto);
            }
            return View();
        }
    }
}
