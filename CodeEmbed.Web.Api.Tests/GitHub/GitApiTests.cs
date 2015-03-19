namespace CodeEmbed.Web.Api.Tests.GitHub
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Web.Http;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public sealed class GitApiTests :
        IDisposable
    {
        private static readonly Uri ApiBaseUri = new Uri("http://localhost:57250/github-git/");

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
        public async Task GetGitCodeDefaultBranchTest()
        {
            var uri = new Uri(ApiBaseUri, "aetos382/CodeEmbed/CodeEmbed.Web.Api.Tests/Test/Test1.txt");

            const string Expected = "Hello, CodeEmbed.";

            string result = await this._client.GetStringAsync(uri);

            Assert.AreEqual(Expected, result);
        }

        [TestMethod]
        public async Task GetGitCodeDefaultBranchTest2()
        {
            var uri = new Uri(ApiBaseUri, "aetos382/CodeEmbed/CodeEmbed.Web.Api.Tests/Test/Foo/Bar/Test2.txt");

            const string Expected = "Hello, CodeEmbed.";

            string result = await this._client.GetStringAsync(uri);

            Assert.AreEqual(Expected, result);
        }

        [TestMethod]
        public async Task GetGitCodeInvalidUserTest()
        {
            var uri = new Uri(ApiBaseUri, "--- invalid user name ---/repository/path");

            using (var response = await this._client.GetAsync(uri))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeInvalidRepositoryTest()
        {
            var uri = new Uri(ApiBaseUri, "aetos382/--- invalid repository name ---/path");

            using (var response = await this._client.GetAsync(uri))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeInvalidPathTest()
        {
            var uri = new Uri(ApiBaseUri, "aetos382/CodeEmbed/--- invalid path ---");

            using (var response = await this._client.GetAsync(uri))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeByBranchTest()
        {
            var uri = new Uri(ApiBaseUri, "aetos382/CodeEmbed/branches/master/CodeEmbed.Web.Api.Tests/Test/Test1.txt");

            const string Expected = "Hello, CodeEmbed.";

            string result = await this._client.GetStringAsync(uri);

            Assert.AreEqual(Expected, result);
        }

        [TestMethod]
        public async Task GetGitCodeInvalidBranchTest()
        {
            var uri = new Uri(ApiBaseUri, "aetos382/CodeEmbed/branches/--- invalid branch name ---/path");

            using (var response = await this._client.GetAsync(uri))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeByBranchTest2()
        {
            var uri = new Uri(ApiBaseUri, "aetos382/CodeEmbed/branches/master/CodeEmbed.Web.Api.Tests/Test/Foo/Bar/Test2.txt");

            const string Expected = "Hello, CodeEmbed.";

            string result = await this._client.GetStringAsync(uri);

            Assert.AreEqual(Expected, result);
        }

        [TestMethod]
        public async Task GetGitCodeByCommitTest()
        {
            var uri = new Uri(ApiBaseUri, "aetos382/CodeEmbed/commits/62905855d49ef1670b10ed176105bf1c6a1cbe86/CodeEmbed.Web.Api.Tests/Test/Test1.txt");

            const string Expected = "Hello, CodeEmbed.";

            string result = await this._client.GetStringAsync(uri);

            Assert.AreEqual(Expected, result);
        }

        [TestMethod]
        public async Task GetGitCodeInvalidCommitTest()
        {
            var uri = new Uri(ApiBaseUri, "aetos382/CodeEmbed/commits/--- invalid commit hash ---/Test/Test1.txt");

            using (var response = await this._client.GetAsync(uri))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeByCommitTest2()
        {
            var uri = new Uri(ApiBaseUri, "aetos382/CodeEmbed/commits/62905855d49ef1670b10ed176105bf1c6a1cbe86/CodeEmbed.Web.Api.Tests/Test/Foo/Bar/Test2.txt");

            const string Expected = "Hello, CodeEmbed.";

            string result = await this._client.GetStringAsync(uri);

            Assert.AreEqual(Expected, result);
        }

        [TestMethod]
        public async Task GetGitCodeByTagTest()
        {
            var uri = new Uri(ApiBaseUri, "aetos382/CodeEmbed/tags/0.1.1/CodeEmbed.Web.Api.Tests/Test/Test1.txt");

            const string Expected = "Hello, CodeEmbed.";

            string result = await this._client.GetStringAsync(uri);

            Assert.AreEqual(Expected, result);
        }

        [TestMethod]
        public async Task GetGitCodeInvalidTagTest()
        {
            var uri = new Uri(ApiBaseUri, "aetos382/CodeEmbed/tags/--- invalid tag name ---/path");

            using (var response = await this._client.GetAsync(uri))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeByTagTest2()
        {
            var uri = new Uri(ApiBaseUri, "aetos382/CodeEmbed/tags/0.1.1/CodeEmbed.Web.Api.Tests/Test/Foo/Bar/Test2.txt");

            const string Expected = "Hello, CodeEmbed.";

            string result = await this._client.GetStringAsync(uri);

            Assert.AreEqual(Expected, result);
        }

        [TestMethod]
        public async Task GetGitCodeGetDirTest()
        {
            var uri = new Uri(ApiBaseUri, "aetos382/CodeEmbed/CodeEmbed.Web.Api.Tests/Test/Foo/Bar");

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
