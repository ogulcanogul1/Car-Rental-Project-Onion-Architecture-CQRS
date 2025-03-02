using App.Dtos.ContactDtos;
using App.WebUI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace App.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly ContactService _contactService;
        public ContactController(ContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateContactDto createContactDto)
        {
            HttpResponseMessage responseMessage = await _contactService.GetContactCreateDataAsync(createContactDto);

            if (responseMessage.IsSuccessStatusCode) 
            {
                return RedirectToAction("Index");   
            }

            return View();

        }
    }
}
