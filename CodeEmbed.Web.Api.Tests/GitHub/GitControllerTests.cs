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
    public class GitControllerTests
    {
        private GitController _controller;

        [TestInitialize]
        public void Setup()
        {
            var controller = new GitController();

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
        public async Task GetGitCodeDefaultBranchTest()
        {
            const string expected = "Hello, GitHub.\nThis is test text.\n";

            using (var response = await this._controller.GetGitCode("aetos382", "CodeEmbed.Tests", "Test.txt"))
            {
                string result = await response.Content.ReadAsStringAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task GetGitCodeDefaultBranchTest2()
        {
            const string expected = "Hello, GitHub.\nThis is test text 2.\n";

            using (var response = await this._controller.GetGitCode("aetos382", "CodeEmbed.Tests", "Foo/Bar/Test2.txt"))
            {
                string result = await response.Content.ReadAsStringAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task GetGitCodeInvaldUserTest()
        {
            using (var response = await this._controller.GetGitCode("--- invalid user name ---", "repository", "path"))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeInvaldRepositoryTest()
        {
            using (var response = await this._controller.GetGitCode("aetos382", "--- invalid repository name ---", "path"))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeInvalidPathTest()
        {
            using (var response = await this._controller.GetGitCode("aetos382", "CodeEmbed.Tests", "--- invalid path ---"))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeByBranchTest()
        {
            const string expected = "Hello, GitHub.\nThis is test text.\n";

            using (var response = await this._controller.GetGitCodeByBranch("aetos382", "CodeEmbed.Tests", "master", "Test.txt"))
            {
                string result = await response.Content.ReadAsStringAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task GetGitCodeInvalidBranchTest()
        {
            using (var response = await this._controller.GetGitCodeByBranch("aetos382", "CodeEmbed.Tests", "--- invalid branch name ---", "Test.txt"))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeByBranchTest2()
        {
            const string expected = "Hello, GitHub.\nThis is test text 2.\n";

            using (var response = await this._controller.GetGitCodeByBranch("aetos382", "CodeEmbed.Tests", "master", "Foo/Bar/Test2.txt"))
            {
                string result = await response.Content.ReadAsStringAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task GetGitCodeByCommitTest()
        {
            const string expected = "Hello, GitHub.\nThis is test text 2.\n";

            using (var response = await this._controller.GetGitCodeByCommit("aetos382", "CodeEmbed.Tests", "ededfbaa1771f48338c9d17abd776de0006e658e", "Foo/Bar/Test2.txt"))
            {
                string result = await response.Content.ReadAsStringAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task GetGitCodeInvalidCommitTest()
        {
            using (var response = await this._controller.GetGitCodeByCommit("aetos382", "CodeEmbed.Tests", "--- invalid commit hash ---", "Test.txt"))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeByCommitTest2()
        {
            const string expected = "Hello, GitHub.\nThis is test text 2.\n";

            using (var response = await this._controller.GetGitCodeByCommit("aetos382", "CodeEmbed.Tests", "ededfbaa1771f48338c9d17abd776de0006e658e", "Foo/Bar/Test2.txt"))
            {
                string result = await response.Content.ReadAsStringAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task GetGitCodeByTagTest()
        {
            const string expected = "Hello, GitHub.\nThis is test text.\n";

            using (var response = await this._controller.GetGitCodeByTag("aetos382", "CodeEmbed.Tests", "tag-a2", "Test.txt"))
            {
                string result = await response.Content.ReadAsStringAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task GetGitCodeInvalidTagTest()
        {
            using (var response = await this._controller.GetGitCodeByTag("aetos382", "CodeEmbed.Tests", "--- invalid tag name ---", "Test.txt"))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeByTagTest2()
        {
            const string expected = "Hello, GitHub.\nThis is test text 2.\n";

            using (var response = await this._controller.GetGitCodeByTag("aetos382", "CodeEmbed.Tests", "tag-a2", "Foo/Bar/Test2.txt"))
            {
                string result = await response.Content.ReadAsStringAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task GetGitCodeBinaryFileTest()
        {
            using (var response = await this._controller.GetGitCode("aetos382", "CodeEmbed.Tests", "Foo/Bar/Test2.zip"))
            {
                Assert.AreEqual(HttpStatusCode.Forbidden, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeGetDirTest()
        {
            using (var response = await this._controller.GetGitCode("aetos382", "CodeEmbed.Tests", "Foo/Bar"))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }
    }
}
