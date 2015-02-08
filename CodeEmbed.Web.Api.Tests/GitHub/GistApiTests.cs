namespace CodeEmbed.Web.Api.Tests.GitHub
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Web.Http;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public sealed class GistApiTests :
        IDisposable
    {
        private static readonly Uri ApiBaseUri = new Uri("http://localhost:57250/github-gist/");

        private HttpClient _client;

        [TestInitialize]
        public void Setup()
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);

            var server = new HttpServer(config);
            this._client = new HttpClient(server);
        }

        [TestCleanup]
        public void Cleanup()
        {
            this.Dispose();
        }

        [TestMethod]
        public async Task GetGistCodeTest()
        {
            var uri = new Uri(ApiBaseUri, "1/gistfile1.txt");

            const string Expected =
                "This is gist. \nThere are many like it, but this one is mine. \nIt is my life. \nI must master it as I must master my life. \nWithout me gist is useless. \nWithout gist, I am useless.";

            string result = await this._client.GetStringAsync(uri);

            Assert.AreEqual(Expected, result);
        }

        [TestMethod]
        public async Task GistIdNotFoundTest()
        {
            var uri = new Uri(ApiBaseUri, "Z/notfound.txt");

            using (var response = await this._client.GetAsync(uri))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GistFileNotFoundTest()
        {
            var uri = new Uri(ApiBaseUri, "1/gistfile2.txt");

            using (var response = await this._client.GetAsync(uri))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        public void Dispose()
        {
            this._client.Dispose();
        }
    }
}
