using App.Dtos.TestimonialDtos;
using App.WebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace App.WebUI.ViewComponents.TestimonialViewComponents
{
    public class _TestimonialComponentPartial : ViewComponent
    {
        private readonly TestimonialService _service;

        public _TestimonialComponentPartial(TestimonialService service)
        {
            _service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            HttpResponseMessage responseMessage =  await _service.GetTestimonialAllDataAsync();
            if (responseMessage.IsSuccessStatusCode) 
            {
                string stringData = await responseMessage.Content.ReadAsStringAsync();
                List<TestimonialResponseDto> jsonData = JsonConvert.DeserializeObject<List<TestimonialResponseDto>>(stringData)!;
                return View(jsonData);
            }
            return View();
        }
    }
}
