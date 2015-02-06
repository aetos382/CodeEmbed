namespace CodeEmbed.GitHubClient.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GitHubClientGistExtensionTests
    {
        [TestMethod]
        public async Task GetGistTest()
        {
            string oauthToken = ConfigurationManager.AppSettings["OAuthToken"];

            using (var client = new GitHubClient(
                this.GetType().FullName,
                oauthToken))
            {
                var gist = await client.GetGist("1");

                Assert.IsNotNull(gist);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(GistNotFoundException))]
        public async Task GistIdNotFoundTest()
        {
            string oauthToken = ConfigurationManager.AppSettings["OAuthToken"];

            using (var client = new GitHubClient(
                this.GetType().FullName,
                oauthToken))
            {
                await client.GetGist("Z");
            }
        }
    }
}
