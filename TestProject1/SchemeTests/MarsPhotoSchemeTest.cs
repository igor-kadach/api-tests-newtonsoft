using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using NUnit.Framework;
using TestProject1.Helpers;

namespace TestProject1.SchemeTests
{
    public class MarsPhotoSchemeTest
    {
        [Test]
        public async Task MarsPhotoScheme()
        {
            var url = "https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?sol=1000&camera=fhaz&api_key=oHvMn9jIoUDuIzTqb3mgpfqj18dE2K1HSREVUvdy";

            var schemaJson = JSchema.Parse(@"{   
                'type': 'object',
                'properties': 
                {
                    'photos': {'type': 'array',
                'items': [
                {
                'type': 'object',
                'properties': {
                    'id': {'type': 'integer'},
                    'sol': {'type': 'integer'},
                    'camera': {'type': 'object',
                'properties': {
                    'id': {'type': 'integer'},
                    'name': {'type': 'string'},
                    'rover_id': {'type': 'integer'},
                    'full_name': {'type': 'string'}
                },
                'required': ['id', 'name', 'rover_id', 'full_name']
                },
                    'img_src': {'type': 'string'},
                    'earth_date': {'type': 'string'},
                    'rover': {'type': 'object',
                'properties': {
                    'id': {'type': 'integer'},
                    'name': {'type': 'string'},
                    'landing_date': {'type': 'string'},
                    'launch_date': {'type': 'string'},
                    'status': {'type': 'string'}
                },
                'required': ['id', 'name', 'landing_date', 'launch_date', 'status']
                }
                },
                'required': ['id', 'sol', 'camera', 'img_src', 'earth_date', 'rover']
                },
                {
                    'type': 'object',
                    'properties': {
                        'id': {'type': 'integer'},
                        'sol': {'type': 'integer'},
                        'camera': {'type': 'object',
                'properties': {
                        'id': {'type': 'integer'},
                        'name': {'type': 'string'},
                        'rover_id': {'type': 'integer'},
                        'full_name': {'type': 'string'}
                },
                'required': ['id', 'name', 'rover_id', 'full_name']
                },
                        'img_src': {'type': 'string'},
                        'earth_date': {'type': 'string'},
                        'rover': {'type': 'object',
                'properties': {
                        'id': {'type': 'integer'},
                        'name': {'type': 'string'},
                        'landing_date': {'type': 'string'},
                        'launch_date': {'type': 'string'},
                        'status': {'type': 'string'}
                },
                'required': ['id', 'name', 'landing_date', 'launch_date', 'status']
                }
                },
                'required': ['id', 'sol', 'camera', 'img_src', 'earth_date', 'rover']
                }
                ]
                }
                },
                'required': ['photos']
                }");

            var response = await HttpClientHelper.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            var json = JObject.Parse(content);
            var actualResult = json.IsValid(schemaJson);

            Assert.IsTrue(actualResult);
        }
    }
}