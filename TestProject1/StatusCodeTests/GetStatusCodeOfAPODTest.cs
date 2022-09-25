using System.Net;
using TestProject1.Helpers;
using NUnit.Framework;

namespace TestProject1.StatusTests
{
    public class GetStatusCodeOfAPODTest
    {
        [Test]
        public async Task GetStatusCodeOfAPOD()
        {
            var url = "https://api.nasa.gov/neo/rest/v1/feed?start_date=2015-09-07&end_date=2015-09-08&api_key=oHvMn9jIoUDuIzTqb3mgpfqj18dE2K1HSREVUvdy";

            var httpResponse = await HttpClientHelper.GetAsync(url);
            var actualResult = httpResponse.StatusCode;
            var expectedResult = HttpStatusCode.OK;

            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}