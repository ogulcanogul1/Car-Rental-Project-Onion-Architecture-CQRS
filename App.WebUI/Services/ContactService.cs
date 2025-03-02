using App.Dtos.ContactDtos;
using Newtonsoft.Json;
using System.Text;

namespace App.WebUI.Services
{
    public class ContactService
    {
        private readonly HttpClient _httpClient;
        private const string url = "https://localhost:7069/api/";
        private const string key = "Contacts";
        public ContactService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        //https://localhost:7069/api/Contacts
        public async Task<HttpResponseMessage> GetContactCreateDataAsync(CreateContactDto createContactDto)
        {
            createContactDto.SendDate = DateTime.Now;
            string jsonData = JsonConvert.SerializeObject(createContactDto);
            HttpContent httpContent = new StringContent(jsonData, Encoding.UTF8,"application/json");
            return await _httpClient.PostAsync(url+key,httpContent);
        }
    }
}
