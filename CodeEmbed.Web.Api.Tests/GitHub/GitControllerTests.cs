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
            const string expected = "Hello, CodeEmbed.";

            using (var response = await this._controller.GetGitCode("aetos382", "CodeEmbed", "CodeEmbed.Web.Api.Tests/Test/Test1.txt"))
            {
                string result = await response.Content.ReadAsStringAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task GetGitCodeDefaultBranchTest2()
        {
            const string expected = "Hello, CodeEmbed.";

            using (var response = await this._controller.GetGitCode("aetos382", "CodeEmbed", "CodeEmbed.Web.Api.Tests/Test/Foo/Bar/Test2.txt"))
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
            using (var response = await this._controller.GetGitCode("aetos382", "CodeEmbed", "--- invalid path ---"))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeByBranchTest()
        {
            const string expected = "Hello, CodeEmbed.";

            using (var response = await this._controller.GetGitCodeByBranch("aetos382", "CodeEmbed", "master", "CodeEmbed.Web.Api.Tests/Test/Test1.txt"))
            {
                string result = await response.Content.ReadAsStringAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task GetGitCodeInvalidBranchTest()
        {
            using (var response = await this._controller.GetGitCodeByBranch("aetos382", "CodeEmbed", "--- invalid branch name ---", "path"))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeByBranchTest2()
        {
            const string expected = "Hello, CodeEmbed.";

            using (var response = await this._controller.GetGitCodeByBranch("aetos382", "CodeEmbed", "master", "CodeEmbed.Web.Api.Tests/Test/Foo/Bar/Test2.txt"))
            {
                string result = await response.Content.ReadAsStringAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task GetGitCodeByCommitTest()
        {
            const string expected = "Hello, CodeEmbed.";

            using (var response = await this._controller.GetGitCodeByCommit("aetos382", "CodeEmbed", "62905855d49ef1670b10ed176105bf1c6a1cbe86", "CodeEmbed.Web.Api.Tests/Test/Foo/Bar/Test2.txt"))
            {
                string result = await response.Content.ReadAsStringAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task GetGitCodeInvalidCommitTest()
        {
            using (var response = await this._controller.GetGitCodeByCommit("aetos382", "CodeEmbed", "--- invalid commit hash ---", "path"))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeByCommitTest2()
        {
            const string expected = "Hello, CodeEmbed.";

            using (var response = await this._controller.GetGitCodeByCommit("aetos382", "CodeEmbed", "62905855d49ef1670b10ed176105bf1c6a1cbe86", "CodeEmbed.Web.Api.Tests/Test/Foo/Bar/Test2.txt"))
            {
                string result = await response.Content.ReadAsStringAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task GetGitCodeByTagTest()
        {
            const string expected = "Hello, CodeEmbed.";

            using (var response = await this._controller.GetGitCodeByTag("aetos382", "CodeEmbed", "0.1.1", "CodeEmbed.Web.Api.Tests/Test/Test1.txt"))
            {
                string result = await response.Content.ReadAsStringAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task GetGitCodeInvalidTagTest()
        {
            using (var response = await this._controller.GetGitCodeByTag("aetos382", "CodeEmbed", "--- invalid tag name ---", "path"))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeByTagTest2()
        {
            const string expected = "Hello, CodeEmbed.";

            using (var response = await this._controller.GetGitCodeByTag("aetos382", "CodeEmbed", "0.1.1", "CodeEmbed.Web.Api.Tests/Test/Foo/Bar/Test2.txt"))
            {
                string result = await response.Content.ReadAsStringAsync();

                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public async Task GetGitCodeBinaryFileTest()
        {
            using (var response = await this._controller.GetGitCode("aetos382", "CodeEmbed", "CodeEmbed.Web.Api.Tests/Test/Foo/Bar/Test2.zip"))
            {
                Assert.AreEqual(HttpStatusCode.Forbidden, response.StatusCode);
            }
        }

        [TestMethod]
        public async Task GetGitCodeGetDirTest()
        {
            using (var response = await this._controller.GetGitCode("aetos382", "CodeEmbed", "CodeEmbed.Web.Api.Tests/Test/Foo/Bar"))
            {
                Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
            }
        }
    }
}
