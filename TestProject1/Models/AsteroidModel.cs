using Newtonsoft.Json;

namespace TestProject1.Responses
{
    public class AsteroidModel
    {
        public string Self { get; set; }
        public string Id { get; set; }

        [JsonProperty("neo_reference_id")]
        public string NeoReferenceId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }

        [JsonProperty("nasa_jpl_url")]
        public string NasaJplUrl { get; set; }

        [JsonProperty("absolute_magnitude_h")]
        public string AbsoluteMagnitudeH { get; set; }
    }
}