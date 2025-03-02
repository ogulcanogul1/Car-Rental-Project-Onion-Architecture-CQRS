
namespace App.WebUI.Services
{
    public class CarPricingService
    {
        private readonly HttpClient _httpClient;
        private const string url = "https://localhost:7069/api/";
        private const string key = "CarPricings";
        //https://localhost:7069/api/CarPricings/GetCarPriceByDay
        public CarPricingService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> GetCarPricingByDayAsync()
        {
            return await _httpClient.GetAsync(url+key+ "/GetCarPriceByDay");
        }
    }
}
