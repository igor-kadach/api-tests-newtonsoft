using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using TestProject1.Helpers;
using TestProject1.Responses;
using NUnit.Framework;

namespace TestProject1.CheckDataTests
{
    public class DateOfAPOD
    {
        [Test]
        public async Task GetNameOfImage()
        {
            var url = "https://api.nasa.gov/planetary/apod?api_key=oHvMn9jIoUDuIzTqb3mgpfqj18dE2K1HSREVUvdy";

            var response = await HttpClientHelper.GetAsync(url);
            var responseData = await response.Content.ReadAsStringAsync();
            var jsonResult = JsonConvert.DeserializeObject<APODModel>(responseData, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            });

            var actualResult = jsonResult.Date;
            var expectedResult = DateTime.Now.ToString("yyyy-MM-dd");

            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
