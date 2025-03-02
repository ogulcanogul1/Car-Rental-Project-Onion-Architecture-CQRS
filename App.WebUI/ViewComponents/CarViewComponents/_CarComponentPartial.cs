using App.Dtos.CarDtos;
using App.Dtos.CarPricingDto;
using App.WebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace App.WebUI.ViewComponents.CarViewComponents
{
    public class _CarComponentPartial : ViewComponent
    {
        private readonly CarPricingService _carPricingService;

        public _CarComponentPartial(CarPricingService carPricingService)
        {
            _carPricingService = carPricingService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            HttpResponseMessage responseMessage = await _carPricingService.GetCarPricingByDayAsync();

            if (responseMessage.IsSuccessStatusCode) 
            {
                string stringData = await responseMessage.Content.ReadAsStringAsync();
                List<CarPricingByTimeDto>? jsonData = JsonConvert.DeserializeObject<List<CarPricingByTimeDto>>(stringData);
                return View(jsonData);
            }
            return View();
        }
    }
}
