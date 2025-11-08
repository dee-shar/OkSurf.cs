using System.Net.Http;

namespace OkSurfApi
{
    public class OkSurf
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://ok.surf/api/v1";
        public OkSurf()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36"
            );
        }

        public async Task<string> GetNewsFeed()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/cors/news-feed");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetCorsNewsSectionNames()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/cors/news-section-names");
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetNewsSectionNames()
        {
            var response = await httpClient.GetAsync($"{apiUrl}/news-section-names");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
