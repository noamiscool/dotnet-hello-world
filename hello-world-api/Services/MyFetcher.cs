// File: Services/MyFetcher.cs
using System.Net.Http;
using System.Threading.Tasks;

namespace hello_world_api.Services
{
    public class MyFetcher
    {
        private readonly HttpClient _client;

        public MyFetcher(HttpClient client)
        {
            _client = client;
        }

        public async Task<string> FetchAsync(string url)
        {
            var response = await _client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
