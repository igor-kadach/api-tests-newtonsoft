using Newtonsoft.Json;

namespace TestProject1.Responses
{
    public class PlanetModel
    {
        public string Date { get; set; }

        public string Id { get; set; }

        public string Dataset { get; set; }
        public string Planet { get; set; }

        [JsonProperty("service_version")]
        public string ServiceVersion { get; set; }
        public string Url { get; set; }
    }
}