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
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed.Tests/Test.txt");

            const string expected = "Hello, GitHub.\nThis is test text.\n";

            string result = await this._client.GetStringAsync(uri);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetGitCodeDefaultBranchTest2()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed.Tests/Foo/Bar/Test2.txt");

            const string expected = "Hello, GitHub.\nThis is test text 2.\n";

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
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed.Tests/--- invalid path ---");

            using (var response = await this._client.GetAsync(uri))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeByBranchTest()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed.Tests/branches/master/Test.txt");

            const string expected = "Hello, GitHub.\nThis is test text.\n";

            string result = await this._client.GetStringAsync(uri);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetGitCodeInvalidBranchTest()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed.Tests/branches/--- invalid branch name ---/Test.txt");

            using (var response = await this._client.GetAsync(uri))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeByBranchTest2()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed.Tests/branches/master/Foo/Bar/Test2.txt");

            const string expected = "Hello, GitHub.\nThis is test text 2.\n";

            string result = await this._client.GetStringAsync(uri);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetGitCodeByCommitTest()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed.Tests/commits/221edc8afea2815163c533cdfbf552bfaf92698d/Test.txt");

            const string expected = "Hello, GitHub.\nThis is test text.\n";

            string result = await this._client.GetStringAsync(uri);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetGitCodeInvalidCommitTest()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed.Tests/commits/--- invalid commit hash ---/Test.txt");

            using (var response = await this._client.GetAsync(uri))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeByCommitTest2()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed.Tests/commits/ededfbaa1771f48338c9d17abd776de0006e658e/Foo/Bar/Test2.txt");

            const string expected = "Hello, GitHub.\nThis is test text 2.\n";

            string result = await this._client.GetStringAsync(uri);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetGitCodeByTagTest()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed.Tests/tags/tag-a2/Test.txt");

            const string expected = "Hello, GitHub.\nThis is test text.\n";

            string result = await this._client.GetStringAsync(uri);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetGitCodeInvalidTagTest()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed.Tests/tags/--- invalid tag name ---/Test.txt");

            using (var response = await this._client.GetAsync(uri))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeByTagTest2()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed.Tests/tags/tag-a2/Foo/Bar/Test2.txt");

            const string expected = "Hello, GitHub.\nThis is test text 2.\n";

            string result = await this._client.GetStringAsync(uri);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetGitCodeBinaryFileTest()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed.Tests/Foo/Bar/Test2.zip");

            using (var response = await this._client.GetAsync(uri))
            {
                Assert.AreEqual(HttpStatusCode.Forbidden, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeGetDirTest()
        {
            var uri = new Uri(_apiBaseUri, "aetos382/CodeEmbed.Tests/Foo/Bar");

            using (var response = await this._client.GetAsync(uri))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }
    }
}
