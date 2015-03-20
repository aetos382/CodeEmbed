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
        public async Task GetGitCodeFromCommitTest_一発目で見つかる()
        {
            const string expected = "Hoge";

            string blobHash = "{CB566919-8484-499C-9EFF-D786477C2904}";

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
                                    Hash = blobHash
                                }
                        }
                };

            var mockCommit = new GitCommitMock
                {
                    Hash = "{BB5EF827-6001-4947-A87F-CE6CFCF58AE5}",
                    Tree = new CommitLinkMock 
                        {
                            Hash = mockTree.Hash
                        }
                };

            var connection = new MockConnection
            {
                DataFactory = uri =>
                {
                    if (uri == GitHubUri.GitBlob("user", "repo", blobHash))
                    {
                        return expected;
                    }

                    throw new ArgumentException();
                }
            };

            var client = new MockClient
            {
                ConnectionFactory = () => connection
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

                    throw new ArgumentException();
                };

            string result = await GitHubClientCodeExtension.GetGitCodeFromCommit(client, "user", "repo", mockCommit.Hash, "path");

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(GitHubNotFoundException))]
        public async Task GetGitCodeFromCommitTest_見つからない()
        {
            var client = new MockClient();

            var mockTree = new GitTreeMock
            {
                Hash = "{2C8CF758-3A36-4C91-A25A-C162D95721D5}",
                Truncated = false,
                Tree = new GitTreeNodeMock[0]
            };

            var mockCommit = new GitCommitMock
            {
                Hash = "{BB5EF827-6001-4947-A87F-CE6CFCF58AE5}",
                Tree = new CommitLinkMock
                {
                    Hash = mockTree.Hash
                }
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

                throw new ArgumentException();
            };

            await GitHubClientCodeExtension.GetGitCodeFromCommit(client, "user", "repo", mockCommit.Hash, "notfound");
        }

        [TestMethod]
        public async Task GetGitCodeFromCommitTest_一階層下って再帰で見つかる()
        {
            const string expected = "Hoge";

            string blobHash = "{CB566919-8484-499C-9EFF-D786477C2904}";

            var mockTree1 = new GitTreeMock
                {
                    Hash = "{AFFA5EA6-B179-4F51-800A-FB6D6DB408CB}",
                    Truncated = false,
                    Tree = new[]
                        {
                            new GitTreeNodeMock
                                {
                                    Hash = blobHash,
                                    Path = "file",
                                    Type = "blob"
                                }
                        }
                };

            var mockTree2 = new GitTreeMock
                {
                    Hash = "{937ACD43-A643-4D23-935D-63FADBDA5D22}",
                    Truncated = true,
                    Tree = new[]
                        {
                            new GitTreeNodeMock
                                {
                                    Hash = mockTree1.Hash,
                                    Path = "path",
                                    Type = "tree"
                                }
                        }
                };

            var mockCommit = new GitCommitMock
            {
                Hash = "{BB5EF827-6001-4947-A87F-CE6CFCF58AE5}",
                Tree = new CommitLinkMock
                {
                    Hash = mockTree2.Hash
                }
            };

            var connection = new MockConnection
            {
                DataFactory = uri =>
                {
                    if (uri == GitHubUri.GitBlob("user", "repo", blobHash))
                    {
                        return expected;
                    }

                    throw new ArgumentException();
                }
            };

            var client = new MockClient
                {
                    ConnectionFactory = () => connection
                };

            client.ModelFactory = uri =>
            {
                if (uri == GitHubUri.GitCommit("user", "repo", mockCommit.Hash))
                {
                    return mockCommit;
                }

                if (uri == GitHubUri.GitTree("user", "repo", mockTree1.Hash, true))
                {
                    return mockTree1;
                }

                if (uri == GitHubUri.GitTree("user", "repo", mockTree2.Hash, true))
                {
                    return mockTree2;
                }

                if (uri == GitHubUri.GitTree("user", "repo", mockTree2.Hash, false))
                {
                    return mockTree2;
                }

                throw new ArgumentException();
            };

            string result = await GitHubClientCodeExtension.GetGitCodeFromCommit(client, "user", "repo", mockCommit.Hash, "path/file");

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public async Task GetGitCodeFromCommitTest_一階層下って非再帰で見つかる()
        {
            const string expected = "Hoge";

            string blobHash = "{CB566919-8484-499C-9EFF-D786477C2904}";

            var mockTree1 = new GitTreeMock
            {
                Hash = "{AFFA5EA6-B179-4F51-800A-FB6D6DB408CB}",
                Truncated = false,
                Tree = new[]
                        {
                            new GitTreeNodeMock
                                {
                                    Hash = blobHash,
                                    Path = "file",
                                    Type = "blob"
                                }
                        }
            };

            var mockTree21 = new GitTreeMock
            {
                Hash = "{937ACD43-A643-4D23-935D-63FADBDA5D22}",
                Truncated = true,
                Tree = new GitTreeNodeMock[0]
            };

            var mockTree22 = new GitTreeMock
            {
                Hash = mockTree21.Hash,
                Truncated = false,
                Tree = new[]
                        {
                            new GitTreeNodeMock
                                {
                                    Hash = mockTree1.Hash,
                                    Path = "path",
                                    Type = "tree"
                                }
                        }
            };

            var mockCommit = new GitCommitMock
            {
                Hash = "{BB5EF827-6001-4947-A87F-CE6CFCF58AE5}",
                Tree = new CommitLinkMock
                {
                    Hash = mockTree21.Hash
                }
            };

            var connection = new MockConnection
            {
                DataFactory = uri =>
                {
                    if (uri == GitHubUri.GitBlob("user", "repo", blobHash))
                    {
                        return expected;
                    }

                    throw new ArgumentException();
                }
            };

            var client = new MockClient
            {
                ConnectionFactory = () => connection
            };

            client.ModelFactory = uri =>
            {
                if (uri == GitHubUri.GitCommit("user", "repo", mockCommit.Hash))
                {
                    return mockCommit;
                }

                if (uri == GitHubUri.GitTree("user", "repo", mockTree1.Hash, true))
                {
                    return mockTree1;
                }

                if (uri == GitHubUri.GitTree("user", "repo", mockTree21.Hash, true))
                {
                    return mockTree21;
                }

                if (uri == GitHubUri.GitTree("user", "repo", mockTree22.Hash, false))
                {
                    return mockTree22;
                }

                throw new ArgumentException();
            };

            string result = await GitHubClientCodeExtension.GetGitCodeFromCommit(client, "user", "repo", mockCommit.Hash, "path/file");

            Assert.AreEqual(expected, result);
        }
    }
}
