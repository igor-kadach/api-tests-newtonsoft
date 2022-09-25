using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using TestProject1.Helpers;
using TestProject1.Responses;
using NUnit.Framework;

namespace TestProject1.CheckDataTests
{
    public class QuantityOfOdjectsTest
    {

        [Test]
        public async Task QuantityOfObjects()
        {
            var url = "https://api.nasa.gov/neo/rest/v1/feed?start_date=2015-09-07&end_date=2015-09-08&api_key=oHvMn9jIoUDuIzTqb3mgpfqj18dE2K1HSREVUvdy";

            var response = await HttpClientHelper.GetAsync(url);
            var responseData = await response.Content.ReadAsStringAsync();
            var getQuantity = JsonConvert.DeserializeObject<ObjectsModel>(responseData, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });

            var actualResult = getQuantity.ElementCount;
            var expectedResult = "25";

            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
