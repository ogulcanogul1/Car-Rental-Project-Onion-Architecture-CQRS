using App.Dtos.CarDtos;
using App.WebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace App.WebUI.ViewComponents.CarViewComponents
{
    public class _MainPageShowCarComponentPartial : ViewComponent
    {
        private readonly CarService _carService;

        public _MainPageShowCarComponentPartial(CarService carService)
        {
            _carService = carService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            HttpResponseMessage responseMessage = await _carService.GetDynamicCarWithBrandAllAsync(false, 5);
            if(responseMessage.IsSuccessStatusCode)
            {
                string jsonData = await responseMessage.Content.ReadAsStringAsync();
                List<CarResponseDto>? dto = JsonConvert.DeserializeObject<List<CarResponseDto>>(jsonData);
                return View(dto);
            }
            return View();
        }
    }
}
