namespace App.WebUI.Services
{
    public class AboutService
    {
        private readonly HttpClient _httpClient;
        private const string url = "https://localhost:7069/api/";
        private const string key = "Abouts";

        public AboutService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> GetAboutAllDataAsync()
        {
            var response = await _httpClient.GetAsync(url+key);
            return response;
        }

        
    }
}
