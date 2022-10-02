using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using TestProject1.Helpers;
using TestProject1.Responses;
using NUnit.Framework;

namespace TestProject1.CheckDataTests
{
    public class GetMagnitudeOfAsteroidTest
    {
        [Test]
        public async Task GetMagnitudeOfAsteroid()
        {
            var url = "https://api.nasa.gov/neo/rest/v1/neo/3542519?api_key=oHvMn9jIoUDuIzTqb3mgpfqj18dE2K1HSREVUvdy";

            var response = await HttpClientHelper.GetAsync(url);
            var responseData = await response.Content.ReadAsStringAsync();
            var getMagnitude = JsonConvert.DeserializeObject<AsteroidModel>(responseData, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });

            var actualResult = getMagnitude.AbsoluteMagnitudeH;
            var expectedResult = "21.8";
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}