namespace CodeEmbed.GitHubClient.Tests.Models
{
    using System;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;
    
    using CodeEmbed.GitHubClient.Models;
    using CodeEmbed.GitHubClient.Serialization;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Newtonsoft.Json;

    [TestClass]
    public class RepositoryTests
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once MemberCanBePrivate.Global
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DeploymentItem(@"Models\Data\RepositoryUser.json")]
        public async Task RepositoryUserDeserializationTest()
        {
            string file = Path.Combine(this.TestContext.DeploymentDirectory, "RepositoryUser.json");

            using (var reader = new StreamReader(file))
            {
                string json = await reader.ReadToEndAsync();

                var resolver = new TypeResolver();
                resolver.Map<IRepositoryUser, SerializableRepositoryUser>();

                var settings = new JsonSerializerSettings();
                settings.ContractResolver = resolver;

                var user = JsonConvert.DeserializeObject<IRepositoryUser>(json, settings);

                Assert.IsNotNull(user);

                Assert.AreEqual("aetos382", user.Login);
                Assert.AreEqual(2569664, user.Id);
                Assert.AreEqual(new Uri("https://avatars.githubusercontent.com/u/2569664?v=3"), user.AvatarUri);
                Assert.AreEqual(string.Empty, user.GravatarId);
                Assert.AreEqual(new Uri("https://api.github.com/users/aetos382"), user.Uri);
                Assert.AreEqual(new Uri("https://github.com/aetos382"), user.HtmlUri);
                Assert.AreEqual(new Uri("https://api.github.com/users/aetos382/followers"), user.FollowersUri);
                Assert.AreEqual("https://api.github.com/users/aetos382/following{/other_user}", user.FollowingUri);
                Assert.AreEqual("https://api.github.com/users/aetos382/gists{/gist_id}", user.GistsUri);
                Assert.AreEqual("https://api.github.com/users/aetos382/starred{/owner}{/repo}", user.StarredUri);
                Assert.AreEqual(new Uri("https://api.github.com/users/aetos382/subscriptions"), user.SubscriptionsUri);
                Assert.AreEqual(new Uri("https://api.github.com/users/aetos382/orgs"), user.OrganizationsUri);
                Assert.AreEqual(new Uri("https://api.github.com/users/aetos382/repos"), user.RepositoriesUri);
                Assert.AreEqual("https://api.github.com/users/aetos382/events{/privacy}", user.EventsUri);
                Assert.AreEqual(new Uri("https://api.github.com/users/aetos382/received_events"), user.ReceivedEventsUri);
                Assert.AreEqual("User", user.Type);
                Assert.AreEqual(false, user.SiteAdministrator);
            }
        }

        [TestMethod]
        [DeploymentItem(@"Models\Data\PublicRepository.json")]
        public async Task PublicRepositoryDeserializationTest()
        {
            string file = Path.Combine(this.TestContext.DeploymentDirectory, "PublicRepository.json");

            using (var reader = new StreamReader(file))
            {
                string json = await reader.ReadToEndAsync();

                var resolver = new TypeResolver();
                resolver.Map<IPublicRepository, SerializablePublicRepository>();
                resolver.Map<IRepositoryUser, SerializableRepositoryUser>();

                var settings = new JsonSerializerSettings();
                settings.ContractResolver = resolver;

                var repository = JsonConvert.DeserializeObject<IPublicRepository>(json, settings);

                Assert.IsNotNull(repository);
                Assert.IsNotNull(repository.Owner);

                Assert.AreEqual(29520811, repository.Id);
                Assert.AreEqual("CodeEmbed", repository.Name);
                Assert.AreEqual("aetos382/CodeEmbed", repository.FullName);
                Assert.AreEqual(false, repository.IsPrivate);
                Assert.AreEqual(new Uri("https://github.com/aetos382/CodeEmbed"), repository.HtmlUri);
                Assert.AreEqual("サイトに GitHub のコードを埋め込むやつ", repository.Description);
                Assert.AreEqual(false, repository.Fork);
                Assert.AreEqual(new Uri("https://api.github.com/repos/aetos382/CodeEmbed"), repository.Uri);
                Assert.AreEqual(new Uri("https://api.github.com/repos/aetos382/CodeEmbed/forks"), repository.ForksUri);
                Assert.AreEqual("https://api.github.com/repos/aetos382/CodeEmbed/keys{/key_id}", repository.KeysUri);
                Assert.AreEqual("https://api.github.com/repos/aetos382/CodeEmbed/collaborators{/collaborator}", repository.CollaboratorsUri);
                Assert.AreEqual(new Uri("https://api.github.com/repos/aetos382/CodeEmbed/teams"), repository.TeamsUri);
                Assert.AreEqual(new Uri("https://api.github.com/repos/aetos382/CodeEmbed/hooks"), repository.HooksUri);
                Assert.AreEqual("https://api.github.com/repos/aetos382/CodeEmbed/issues/events{/number}", repository.IssueEventsUri);
                Assert.AreEqual(new Uri("https://api.github.com/repos/aetos382/CodeEmbed/events"), repository.EventsUri);
                Assert.AreEqual("https://api.github.com/repos/aetos382/CodeEmbed/assignees{/user}", repository.AssigneesUri);
                Assert.AreEqual("https://api.github.com/repos/aetos382/CodeEmbed/branches{/branch}", repository.BranchesUri);
                Assert.AreEqual(new Uri("https://api.github.com/repos/aetos382/CodeEmbed/tags"), repository.TagsUri);
                Assert.AreEqual("https://api.github.com/repos/aetos382/CodeEmbed/git/blobs{/sha}", repository.BlobsUri);
                Assert.AreEqual("https://api.github.com/repos/aetos382/CodeEmbed/git/tags{/sha}", repository.GitTagsUri);
                Assert.AreEqual("https://api.github.com/repos/aetos382/CodeEmbed/git/refs{/sha}", repository.GitReferenesUri);
                Assert.AreEqual("https://api.github.com/repos/aetos382/CodeEmbed/git/trees{/sha}", repository.TreesUri);
                Assert.AreEqual("https://api.github.com/repos/aetos382/CodeEmbed/statuses/{sha}", repository.StatusesUri);
                Assert.AreEqual(new Uri("https://api.github.com/repos/aetos382/CodeEmbed/languages"), repository.LanguagesUri);
            }
        }

        [TestMethod]
        [DeploymentItem(@"Models\Data\Repository.json")]
        public async Task RepositoryDeserializationTest()
        {
            string file = Path.Combine(this.TestContext.DeploymentDirectory, "Repository.json");

            using (var reader = new StreamReader(file))
            {
                string json = await reader.ReadToEndAsync();

                var resolver = new TypeResolver();
                resolver.Map<IRepository, SerializableRepository>();
                resolver.Map<IRepositoryUser, SerializableRepositoryUser>();

                var settings = new JsonSerializerSettings();
                settings.ContractResolver = resolver;

                var repository = JsonConvert.DeserializeObject<IRepository>(json, settings);

                Assert.IsNotNull(repository);
                Assert.IsNotNull(repository.Owner);

                Assert.AreEqual(29520811, repository.Id);
                Assert.AreEqual("CodeEmbed", repository.Name);
                Assert.AreEqual("aetos382/CodeEmbed", repository.FullName);
                Assert.AreEqual(false, repository.IsPrivate);
                Assert.AreEqual(new Uri("https://github.com/aetos382/CodeEmbed"), repository.HtmlUri);
                Assert.AreEqual("サイトに GitHub のコードを埋め込むやつ", repository.Description);
                Assert.AreEqual(false, repository.Fork);
                Assert.AreEqual(new Uri("https://api.github.com/repos/aetos382/CodeEmbed"), repository.Uri);
                Assert.AreEqual(new Uri("https://api.github.com/repos/aetos382/CodeEmbed/forks"), repository.ForksUri);
            }
        }
    }
}
