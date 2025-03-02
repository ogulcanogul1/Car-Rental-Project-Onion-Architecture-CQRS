namespace App.WebUI.Services
{
    public class TestimonialService
    {
        private readonly HttpClient _httpClient;
        private const string url = "https://localhost:7069/api/";
        private const string key = "Testimonials";
        public TestimonialService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> GetTestimonialAllDataAsync()
        {
            HttpResponseMessage responseMessage = await _httpClient.GetAsync(url+key);

            return responseMessage;
        }
    }
}
