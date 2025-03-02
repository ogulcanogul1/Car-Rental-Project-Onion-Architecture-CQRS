namespace App.WebUI.Services
{
    public class CarService
    {
        private readonly HttpClient _httpClient;
        private const string url = "https://localhost:7069/api/"; 
        private const string key = "Cars";
        public CarService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<HttpResponseMessage> GetCarsWithBrandAllData()
        {
            HttpResponseMessage responseMessage = await _httpClient.GetAsync(url+key+"/WithBrand");
            return responseMessage;
        }

        public async Task<HttpResponseMessage> GetDynamicCarWithBrandAllAsync(bool isFirst, int count)
        {
            return await _httpClient.GetAsync(url+key+$"/WithBrandDescending?IsTop={isFirst}&Count={count}");
        }

        //https://localhost:7069/api/Cars/WithBrandDescending?IsTop=false&Count=2
    }
}
