﻿namespace CodeEmbed.GitHubClient.Tests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CodeEmbed.Configuration;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Newtonsoft.Json;

    [TestClass]
    public sealed class GitHubClientExtensionTests :
        IDisposable
    {
        private static string _oauthToken;

        private GitHubClient _client;

        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            _oauthToken = new ConfigurationStore().GetConfigurationValue("github_oauth_token");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            this._client = new GitHubClient(this.GetType().FullName, _oauthToken);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            this.Dispose();
        }

        [TestMethod]
        public async Task GetGistTest()
        {
            var gist = await this._client.GetGist("1");

            Assert.IsNotNull(gist);
        }

        [TestMethod]
        [ExpectedException(typeof(GistNotFoundException))]
        public async Task GistIdNotFoundTest()
        {
            await this._client.GetGist("Z");
        }

        public void Dispose()
        {
            this._client.Dispose();
        }
    }
}
