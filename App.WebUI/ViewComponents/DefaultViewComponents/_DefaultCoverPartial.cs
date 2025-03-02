using App.Dtos.BannerDtos;
using App.WebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace App.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultCoverPartial : ViewComponent
    {
        private readonly BannerService _service;

        public _DefaultCoverPartial(BannerService service)
        {
            _service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            HttpResponseMessage responseMessage = await _service.GetAllBannerAsync();
            if(responseMessage.IsSuccessStatusCode)
            {
                string jsonData =  await responseMessage.Content.ReadAsStringAsync();
                List<BannerResponseDto>? dto =  JsonConvert.DeserializeObject<List<BannerResponseDto>>(jsonData);
                return View(dto);
            }
            return View();
        }
    }
}
