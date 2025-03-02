using App.Dtos.AboutDtos;
using App.WebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace App.WebUI.ViewComponents.AboutViewComponents;

public class _AboutComponentPartial : ViewComponent
{
    private readonly AboutService _aboutService;

    public _AboutComponentPartial(AboutService aboutService)
    {
        _aboutService = aboutService;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        HttpResponseMessage responseMessage = await _aboutService.GetAboutAllDataAsync();
        if (responseMessage.IsSuccessStatusCode) 
        {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<AboutResponseDto>>(jsonData);
            return View(values);
        }
        return View();
    }
}
