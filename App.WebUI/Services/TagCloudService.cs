using System.Security.Policy;

namespace App.WebUI.Services
{
    public class TagCloudService
    {
        private readonly HttpClient _httpClient;
        private const string url = "https://localhost:7069/api/";
        private const string key = "TagClouds";
        public TagCloudService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        //https://localhost:7069/api/TagClouds/TagCloudsByBlogId/6
        public async Task<HttpResponseMessage> GetTagCloudByBlogId(int blogId) => await _httpClient.GetAsync(url+key+$"/TagCloudsByBlogId/{blogId}");

    }
}
