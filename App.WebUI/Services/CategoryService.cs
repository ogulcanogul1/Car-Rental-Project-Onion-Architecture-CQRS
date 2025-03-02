namespace App.WebUI.Services
{
    public class CategoryService
    {
        private readonly HttpClient _httpClient;
        private const string url = "https://localhost:7069/api/";
        private const string key = "Categories";
        //https://localhost:7069/api/Categories/GroupByCategoryNameBlogCount
        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        
        public async Task<HttpResponseMessage> GetCategories() => await _httpClient.GetAsync(url+key+ "/GroupByCategoryNameBlogCount");

    }
}
