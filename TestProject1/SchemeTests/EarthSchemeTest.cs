using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using NUnit.Framework;
using TestProject1.Helpers;

namespace TestProject1.SchemeTests
{
    public class EarthSchemeTest
    {
        [Test]
        public async Task EarthScheme()
        {
            var url = "https://api.nasa.gov/planetary/earth/assets?lon=-95.33&lat=29.78&date=2018-01-01&&dim=0.10&api_key=oHvMn9jIoUDuIzTqb3mgpfqj18dE2K1HSREVUvdy";

            var schemaJson = JSchema.Parse(@"{   
                'type': 'object',
                'properties': 
                {
                    'date': {'type': 'string'},
                    'id': {'type': 'string'},
                    'resource': {'type': 'object',
                'properties': 
                {
                    'dataset': {'type': 'string'},
                    'planet': {'type': 'string'}
                },
                'required': ['dataset','planet']
                },
                    'service_version': {'type': 'string'},
                    'url': {'type': 'string'}
                },
                'required': ['date', 'id', 'resource', 'service_version', 'url']
                }");

            var response = await HttpClientHelper.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            var json = JObject.Parse(content);

            var actualResult = json.IsValid(schemaJson);
            Assert.IsTrue(actualResult);
        }
    }
}