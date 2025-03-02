namespace App.WebUI.Services
{
    public class BannerService
    {
        private readonly HttpClient _httpClient;
        private const string url = "https://localhost:7069/api/";
        private const string key = "Banners";
        public BannerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> GetAllBannerAsync()
        {
            return await _httpClient.GetAsync(url+key);
        }
    }
}
