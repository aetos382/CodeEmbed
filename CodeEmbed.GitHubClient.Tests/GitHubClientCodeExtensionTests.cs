namespace CodeEmbed.GitHubClient.Tests
{
    using System;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Models;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class GitHubClientCodeExtensionTests
    {
        [TestMethod]
        public async Task GetGitCodeFromCommitTest()
        {
            var connection = new MockConnection
                {
                    DataFactory = uri =>
                        {
                            if (uri == new Uri("http://www.example.com"))
                            {
                                return "Hoge";
                            }

                            throw new InvalidOperationException();
                        }
                };

            var client = new MockClient
                {
                    ConnectionFactory = () => connection
                };

            var mockCommit = new GitCommitMock
                {
                    Hash = "{BB5EF827-6001-4947-A87F-CE6CFCF58AE5}",
                    Tree = new CommitLinkMock 
                        {
                            Hash = "{2C8CF758-3A36-4C91-A25A-C162D95721D5}"
                        }
                };

            var mockTree = new GitTreeMock
                {
                    Hash = "{2C8CF758-3A36-4C91-A25A-C162D95721D5}",
                    Truncated = false,
                    Tree = new[]
                        {
                            new GitTreeNodeMock
                                {
                                    Path = "path",
                                    Type = "blob",
                                    Hash = "{CB566919-8484-499C-9EFF-D786477C2904}"
                                }
                        }
                };

            var mockBlob = new GitBlobMock
                {
                    Hash = "{CB566919-8484-499C-9EFF-D786477C2904}",
                    Uri = new Uri("http://www.example.com")
                };

            client.ModelFactory = uri =>
                {
                    if (uri == GitHubUri.GitCommit("user", "repo", mockCommit.Hash))
                    {
                        return mockCommit;
                    }

                    if (uri == GitHubUri.GitTree("user", "repo", mockTree.Hash, true))
                    {
                        return mockTree;
                    }

                    if (uri == GitHubUri.GitBlob("user", "repo", mockBlob.Hash))
                    {
                        return mockBlob;
                    }

                    throw new InvalidOperationException();
                };

            string result = await GitHubClientCodeExtension.GetGitCodeFromCommit(client, "user", "repo", mockCommit.Hash, "path");
            Assert.AreEqual("Hoge", result);
        }
    }
}
