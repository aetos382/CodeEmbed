namespace CodeEmbed.Web.Api.Tests.GitHub
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Web.Http;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GitApiTests
    {
        private static readonly Uri _apiBaseUri = new Uri("http://localhost:57250/github-git/");

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
            this._client.Dispose();
        }

        [TestMethod]
        public async Task GetGitCodeDefaultBranchTest()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed/CodeEmbed.Web.Api.Tests/Test/Test1.txt");

            const string expected = "Hello, CodeEmbed.";

            string result = await this._client.GetStringAsync(uri);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetGitCodeDefaultBranchTest2()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed/CodeEmbed.Web.Api.Tests/Test/Foo/Bar/Test2.txt");

            const string expected = "Hello, CodeEmbed.";

            string result = await this._client.GetStringAsync(uri);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetGitCodeInvaldUserTest()
        {
            var uri = new Uri(_apiBaseUri, "--- invalid user name ---/repository/path");

            using (var response = await this._client.GetAsync(uri))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeInvaldRepositoryTest()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/--- invalid repository name ---/path");

            using (var response = await this._client.GetAsync(uri))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeInvalidPathTest()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed/--- invalid path ---");

            using (var response = await this._client.GetAsync(uri))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeByBranchTest()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed/branches/master/CodeEmbed.Web.Api.Tests/Test/Test1.txt");

            const string expected = "Hello, CodeEmbed.";

            string result = await this._client.GetStringAsync(uri);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetGitCodeInvalidBranchTest()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed/branches/--- invalid branch name ---/path");

            using (var response = await this._client.GetAsync(uri))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeByBranchTest2()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed/branches/master/CodeEmbed.Web.Api.Tests/Test/Foo/Bar/Test2.txt");

            const string expected = "Hello, CodeEmbed.";

            string result = await this._client.GetStringAsync(uri);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetGitCodeByCommitTest()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed/commits/0a59989a70ac01c201379f7b267368a4f5a4a3eb/Test/Test1.txt");

            const string expected = "Hello, CodeEmbed.";

            string result = await this._client.GetStringAsync(uri);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetGitCodeInvalidCommitTest()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed/commits/--- invalid commit hash ---/Test/Test1.txt");

            using (var response = await this._client.GetAsync(uri))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeByCommitTest2()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed/commits/0a59989a70ac01c201379f7b267368a4f5a4a3eb/Test/Foo/Bar/Test2.txt");

            const string expected = "Hello, CodeEmbed.";

            string result = await this._client.GetStringAsync(uri);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetGitCodeByTagTest()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed/tags/test/Test/Test1.txt");

            const string expected = "Hello, CodeEmbed.";

            string result = await this._client.GetStringAsync(uri);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetGitCodeInvalidTagTest()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed/tags/--- invalid tag name ---/path");

            using (var response = await this._client.GetAsync(uri))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeByTagTest2()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed/tags/test/Test/Foo/Bar/Test2.txt");

            const string expected = "Hello, CodeEmbed.";

            string result = await this._client.GetStringAsync(uri);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetGitCodeBinaryFileTest()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed/Test/Foo/Bar/Test2.zip");

            using (var response = await this._client.GetAsync(uri))
            {
                Assert.AreEqual(HttpStatusCode.Forbidden, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeGetDirTest()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed/Test/Foo/Bar");

            using (var response = await this._client.GetAsync(uri))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }
    }
}
