using Newtonsoft.Json;

namespace TestProject1.Responses
{
    public class ObjectsResponce
    {
        public string Next { get; set; }
        public string Previous { get; set; }
        public string Self { get; set; }
        [JsonProperty("element_count")]
        public string ElementCount { get; set; }
    }
}