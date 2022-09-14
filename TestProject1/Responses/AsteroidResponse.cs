using Newtonsoft.Json;

namespace TestProject1.Responses
{
    public class AsteroidResponse
    {
        public string Self { get; set; }
        public string Id { get; set; }

        [JsonProperty("eoo_reference_id")]
        public string NeoReferenceId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Nasa_jpl_url { get; set; }

        [JsonProperty("absolute_magnitude_h")]
        public string AbsoluteMagnitudeH { get; set; }
    }
}