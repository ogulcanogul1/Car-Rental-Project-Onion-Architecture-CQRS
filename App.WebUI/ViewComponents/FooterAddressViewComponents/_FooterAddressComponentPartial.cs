using App.Dtos.FooterAddressDtos;
using App.WebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace App.WebUI.ViewComponents.FooterAddressViewComponents
{
    public class _FooterAddressComponentPartial : ViewComponent
    {
        private readonly FooterAddressService _service;

        public _FooterAddressComponentPartial(FooterAddressService service)
        {
            _service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            HttpResponseMessage responseMessage =  await _service.GetFooterAddressAllDataAsync();

            if(responseMessage.IsSuccessStatusCode)
            {
                string stringData = await responseMessage.Content.ReadAsStringAsync();
                List<FooterAddressResponseDto>? jsonData =  JsonConvert.DeserializeObject<List<FooterAddressResponseDto>>(stringData);
                return View(jsonData);
            }
            return View();
        }
    }
}
