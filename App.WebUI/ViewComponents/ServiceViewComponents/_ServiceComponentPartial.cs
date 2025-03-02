using App.Dtos.ServiceDtos;
using App.WebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace App.WebUI.ViewComponents.ServiceViewComponents
{
    public class _ServiceComponentPartial : ViewComponent
    {
        private readonly ServiceService _service;

        public _ServiceComponentPartial(ServiceService service)
        {
            _service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            HttpResponseMessage responseMessage = await _service.GetServiceAllDataAsync();
            if(responseMessage.IsSuccessStatusCode)
            {
                String stringData = await responseMessage.Content.ReadAsStringAsync();
                List<ServiceResponseDto> result = JsonConvert.DeserializeObject<List<ServiceResponseDto>>(stringData)!;
                return View(result);
                
            }
            return View();
        }
    }
}
