using Newtonsoft.Json;

namespace TestProject1.Responses
{
    public class APODModel
    {
        public string Copyright { get; set; }
        public string Date { get; set; }
        public string Explanation { get; set; }
        public string Hdurl { get; set; }

        [JsonProperty("media_type")]
        public string MediaType { get; set; }

        [JsonProperty("service_version")]
        public string ServiceVersion { get; set; }
        public string Url { get; set; }
    }
}