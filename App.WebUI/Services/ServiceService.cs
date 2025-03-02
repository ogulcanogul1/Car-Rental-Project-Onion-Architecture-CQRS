namespace App.WebUI.Services
{
    public class ServiceService
    {
        private readonly HttpClient _httpClient;
        private const string url = "https://localhost:7069/api/";
        private const string key = "Services";

        public ServiceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> GetServiceAllDataAsync()
        {
            HttpResponseMessage responseMessage = await _httpClient.GetAsync(url+key);
            return responseMessage;
        }
    }
}
