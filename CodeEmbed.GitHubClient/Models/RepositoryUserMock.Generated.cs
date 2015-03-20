#if BUILD_MOCK

namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;

    using CodeEmbed.GitHubClient;

    [GeneratedCode("ModelMock.tt", "1.0")]
    [DebuggerStepThrough]
    public partial class RepositoryUserMock :
        IRepositoryUser
    {

        /// <summary>Map to "login"</summary>
        public String Login { get; set; }

        /// <summary>Map to "id"</summary>
        public Int64 Id { get; set; }

        /// <summary>Map to "avatar_url"</summary>
        public Uri AvatarUri { get; set; }

        /// <summary>Map to "gravatar_id"</summary>
        public String GravatarId { get; set; }

        /// <summary>Map to "url"</summary>
        public Uri Uri { get; set; }

        /// <summary>Map to "html_url"</summary>
        public Uri HtmlUri { get; set; }

        /// <summary>Map to "followers_url"</summary>
        public Uri FollowersUri { get; set; }

        /// <summary>Map to "following_url"</summary>
        public String FollowingUri { get; set; }

        /// <summary>Map to "gists_url"</summary>
        public String GistsUri { get; set; }

        /// <summary>Map to "starred_url"</summary>
        public String StarredUri { get; set; }

        /// <summary>Map to "subscriptions_url"</summary>
        public Uri SubscriptionsUri { get; set; }

        /// <summary>Map to "organizations_url"</summary>
        public Uri OrganizationsUri { get; set; }

        /// <summary>Map to "repos_url"</summary>
        public Uri RepositoriesUri { get; set; }

        /// <summary>Map to "events_url"</summary>
        public String EventsUri { get; set; }

        /// <summary>Map to "received_events_url"</summary>
        public Uri ReceivedEventsUri { get; set; }

        /// <summary>Map to "type"</summary>
        public String Type { get; set; }

        /// <summary>Map to "site_admin"</summary>
        public Boolean SiteAdministrator { get; set; }
    }
}

#endif
