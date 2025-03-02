using NuGet.Protocol;

namespace App.WebUI.Services
{
    public class FooterAddressService
    {
        private readonly HttpClient _httpClient;
        private const string url = "https://localhost:7069/api/";
        private const string key = "FooterAddresses";
        //https://localhost:7069/api/FooterAddresses
        public FooterAddressService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> GetFooterAddressAllDataAsync()
        {
            HttpResponseMessage responseMessage =  await _httpClient.GetAsync(url+key);
            return responseMessage;
        }
    }
}
