namespace CodeEmbed.GitHubClient.Tests.Models
{
    using System;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;
    
    using CodeEmbed.GitHubClient.Models;
    using CodeEmbed.GitHubClient.Serialization;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RepositoryTests
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once MemberCanBePrivate.Global
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DeploymentItem(@"Models\Data\Repository.json")]
        public async Task RepositoryDeserializationTest()
        {
            string file = Path.Combine(this.TestContext.DeploymentDirectory, "Repository.json");

            using (var reader = new StreamReader(file))
            {
                var serializer = new JsonNetSerializer();
                serializer.MapType<IRepository, SerializableRepository>();
                serializer.MapType<IRepositoryUser, SerializableRepositoryUser>();

                var repository = await serializer.Deserialize<IRepository>(reader, CancellationToken.None);

                Assert.IsNotNull(repository);
                Assert.IsNotNull(repository.Owner);

                Assert.AreEqual(29520811, repository.Id);
                Assert.AreEqual("CodeEmbed", repository.Name);
                Assert.AreEqual("aetos382/CodeEmbed", repository.FullName);

                Assert.AreEqual("aetos382", repository.Owner.Login);
                Assert.AreEqual(2569664, repository.Owner.Id);
                Assert.AreEqual(new Uri("https://avatars.githubusercontent.com/u/2569664?v=3"), repository.Owner.AvatarUri);
                Assert.AreEqual(string.Empty, repository.Owner.GravatarId);
                Assert.AreEqual(new Uri("https://api.github.com/users/aetos382"), repository.Owner.Uri);
                Assert.AreEqual(new Uri("https://github.com/aetos382"), repository.Owner.HtmlUri);
                Assert.AreEqual(new Uri("https://api.github.com/users/aetos382/followers"), repository.Owner.FollowersUri);
                Assert.AreEqual("https://api.github.com/users/aetos382/following{/other_user}", repository.Owner.FollowingUri);
                Assert.AreEqual("https://api.github.com/users/aetos382/gists{/gist_id}", repository.Owner.GistsUri);
                Assert.AreEqual("https://api.github.com/users/aetos382/starred{/owner}{/repo}", repository.Owner.StarredUri);
                Assert.AreEqual(new Uri("https://api.github.com/users/aetos382/subscriptions"), repository.Owner.SubscriptionsUri);
                Assert.AreEqual(new Uri("https://api.github.com/users/aetos382/orgs"), repository.Owner.OrganizationsUri);
                Assert.AreEqual(new Uri("https://api.github.com/users/aetos382/repos"), repository.Owner.RepositoriesUri);
                Assert.AreEqual("https://api.github.com/users/aetos382/events{/privacy}", repository.Owner.EventsUri);
                Assert.AreEqual(new Uri("https://api.github.com/users/aetos382/received_events"), repository.Owner.ReceivedEventsUri);
                Assert.AreEqual("User", repository.Owner.Type);
                Assert.AreEqual(false, repository.Owner.SiteAdministrator);

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
