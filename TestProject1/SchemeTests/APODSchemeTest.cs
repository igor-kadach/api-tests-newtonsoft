using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using NUnit.Framework;
using TestProject1.Helpers;

namespace TestProject1.SchemeTests
{
    public class APODSchemeTest
    {
        [Test]
        public async Task APODScheme()
        {
            var url = "https://api.nasa.gov/planetary/apod?api_key=oHvMn9jIoUDuIzTqb3mgpfqj18dE2K1HSREVUvdy";

            var schemaJson = JSchema.Parse(@"{
               'type': 'object',
               'properties': 
               {
                   'copyright': {'type':'string'},
                   'date': {'type':'string'},
                   'explanation': {'type':'string'},
                   'hdurl': {'type':'string'},
                   'media_type': {'type':'string'},
                   'service_version': {'type':'string'},
                   'title': {'type':'string'},
                   'url': {'type':'string'}
               }
            }");

            var response = await HttpClientHelper.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            var json = JObject.Parse(content);
            var actualResult = json.IsValid(schemaJson);

            Assert.IsTrue(actualResult);
        }
    }
}