using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using TestProject1.Helpers;
using TestProject1.Responses;
using NUnit.Framework;

namespace TestProject1.CheckDataTests
{
    public class CheckPlanetIdTest
    {
        [Test]
        public async Task GetPlanetId()
        {
            var url = "https://api.nasa.gov/planetary/earth/assets?lon=-95.33&lat=29.78&date=2018-01-01&&dim=0.10&api_key=oHvMn9jIoUDuIzTqb3mgpfqj18dE2K1HSREVUvdy";

            var response = await HttpClientHelper.GetAsync(url);
            var responseData = await response.Content.ReadAsStringAsync();
            var getPlanetId = JsonConvert.DeserializeObject<PlanetModel>(responseData, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });

            var actualResult = getPlanetId.Id;
            var expectedResult = "LANDSAT/LC08/C01/T1_SR/LC08_025039_20180103";

            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
