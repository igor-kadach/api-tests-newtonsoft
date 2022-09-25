using System.Net;
using TestProject1.Helpers;
using NUnit.Framework;

namespace TestProject1.StatusTests
{
    public class GetStatusCodeOfGeneLabTest
    {
        [Test]
        public async Task GetStatusCodeOfGeneLab()
        {
            var url = "https://genelab-data.ndc.nasa.gov/genelab/data/glds/files/87";

            var httpResponse = await HttpClientHelper.GetAsync(url);
            var actualResult = httpResponse.StatusCode;
            var expectedResult = HttpStatusCode.OK;

            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}