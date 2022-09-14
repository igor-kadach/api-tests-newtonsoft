using NUnit.Framework;
using System.Net;
using TestProject1.Helpers;

namespace TestProject1.StatusTests
{
    public class GetStatusCodeOfTechPortTest
    {
        [Test]
        public async Task GetStatusCodeOfTechPort()
        {
            var url = "https://api.nasa.gov/techport/api/projects/17792?api_key=oHvMn9jIoUDuIzTqb3mgpfqj18dE2K1HSREVUvdy";

            var httpResponse = await HttpClientHelper.GetAsync(url);
            var statusCode = httpResponse.StatusCode;

            Assert.That(statusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}