namespace CodeEmbed.Core.Tests.GitHub
{
    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;

    using CodeEmbed.Core.GitHub;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GistClientTests
    {
        [TestMethod]
        public async Task GetGistCodeTest()
        {
            var client = new GitHubClient(this.GetType().FullName);

            string result = await client.GetGistCode("1", "gistfile1.txt");

            const string expected =
                "This is gist. \nThere are many like it, but this one is mine. \nIt is my life. \nI must master it as I must master my life. \nWithout me gist is useless. \nWithout gist, I am useless.";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetVersionedGistCodeTest()
        {
            var client = new GitHubClient(this.GetType().FullName);

            string result = await client.GetGistCode("1", "8afc134bf14f8f56ed2e7234128490d9946e8c16", "gistfile1.txt");

            const string expected =
                "This is gist. There are many like it, but this one is mine. It is my life. I must master it as I must master my life. Without me gist is useless. Without gist, I am useless.";

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(GistFileNotFoundException))]
        public async Task GetGistCodeVersionNotFoundTest()
        {
            var client = new GitHubClient(this.GetType().FullName);

            try
            {
                await client.GetGistCode("1", "--- invalid version ---", "gistfile1.txt");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(GistFileNotFoundException))]
        public async Task GetGistCodeFileNotFoundTest()
        {
            var client = new GitHubClient(this.GetType().FullName);

            try
            {
                await client.GetGistCode("1", "--- invalid filename ---");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }
        }
    }
}
