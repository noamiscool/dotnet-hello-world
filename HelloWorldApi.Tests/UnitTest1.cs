// File: MyFetcherTests.cs
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.Protected;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using hello_world_api.Services;

namespace HelloWorldApi.Tests
{
    [TestClass]
    public class MyFetcherTests
    {
        [TestMethod]
        public async Task FetchAsync_RealRequest()
        {
            var httpClient = new HttpClient();
            var fetcher = new MyFetcher(httpClient);

            var result = await fetcher.FetchAsync("https://webhook.site/02389481-94ae-4cf5-b9d4-6c3f6b9a1f7b/testt");

            Assert.IsTrue(result != null); // You can tailor this check based on your webhook site response
        }
    }
}
