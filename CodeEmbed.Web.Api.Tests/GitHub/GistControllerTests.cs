namespace CodeEmbed.Web.Api.Tests.GitHub
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Web.Http;
    using System.Web.Http.Hosting;

    using CodeEmbed.Web.Api.Controllers.GitHub;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GistControllerTests
    {
        private GistController _controller;

        [TestInitialize]
        public void Setup()
        {
            var controller = new GistController();

            var request = new HttpRequestMessage();
            request.Properties.Add(HttpPropertyKeys.HttpConfigurationKey, new HttpConfiguration());

            controller.Request = request;

            this._controller = controller;
        }

        [TestCleanup]
        public void Cleanup()
        {
            this._controller.Dispose();
        }

        [TestMethod]
        public async Task GetGistCodeTest()
        {
            const string expected =
                "This is gist. \nThere are many like it, but this one is mine. \nIt is my life. \nI must master it as I must master my life. \nWithout me gist is useless. \nWithout gist, I am useless.";

            using (var response = await this._controller.GetGistCode("1", "gistfile1.txt"))
            {
                string result = await response.Content.ReadAsStringAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task GistIdNotFoundTest()
        {
            using (var response = await this._controller.GetGistCode("X", "gistfile1.txt"))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GistFileNotFoundTest()
        {
            using (var response = await this._controller.GetGistCode("1", "gistfile2.txt"))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }
    }
}
