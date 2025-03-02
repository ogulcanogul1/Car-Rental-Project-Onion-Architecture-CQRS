namespace App.WebUI.Services
{
    public class BlogService 
    {
        private readonly HttpClient _httpClient;
        private const string url = "https://localhost:7069/api/";
        private const string key = "Blogs";
        public BlogService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        //https://localhost:7069/api/Blogs/GetDynamicAllBlogsWithAuthor?IsFirst=true&Count=3
        //https://localhost:7069/api/Blogs/GetAllBlogsWithAuthor
        public async Task<HttpResponseMessage> GetDynamicBlogWithAuthor(bool isFirst,int count) => await _httpClient.GetAsync(url+key+$"/GetDynamicAllBlogsWithAuthor?IsFirst={isFirst}&Count={count}");

        public async Task<HttpResponseMessage> GetAllBlogWithAuthorAsync()
        => await _httpClient.GetAsync(url + key + "/GetAllBlogsWithAuthor");

        public async Task<HttpResponseMessage> GetBlogByIdAsync(int id)
        {
            return await _httpClient.GetAsync(url + key + $"/{id}");
        }

        public async Task<HttpResponseMessage> GetAuthorDetailByBlogIdAsync(int blogId)
        {
            return await _httpClient.GetAsync(url + key + $"/GetBlogWithAuthor/{blogId}");
        }

    }
}
