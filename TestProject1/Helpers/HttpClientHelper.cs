using System.Net.Http.Headers;

namespace TestProject1.Helpers
{
    public static class HttpClientHelper
    {
        private static readonly HttpClient _httpClient;
        static HttpClientHelper()
        {
            _httpClient = new HttpClient();
            var jsonHeader = new MediaTypeWithQualityHeaderValue("application/json");
            var requestHeaders = _httpClient.DefaultRequestHeaders;
            requestHeaders.Accept.Add(jsonHeader);
        }
        public async static Task<HttpResponseMessage> GetAsync(string url)
        {
            return await _httpClient.GetAsync(url);
        }
    }
}