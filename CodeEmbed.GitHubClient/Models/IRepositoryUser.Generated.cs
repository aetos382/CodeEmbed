








namespace CodeEmbed.GitHubClient.Models
{
    using System;
    using System.CodeDom.Compiler;
    using System.Diagnostics.Contracts;
    
    using CodeEmbed.GitHubClient;
    using CodeEmbed.GitHubClient.Models.Contracts;
    
    [GeneratedCode("ModelInterface.tt", "1.0")]
    [ContractClass(typeof(RepositoryUserContract))]
    public partial interface IRepositoryUser
    {
        /// <summary>Map to "login"</summary>
        String Login { [Pure] get; }

        /// <summary>Map to "id"</summary>
        Int64 Id { [Pure] get; }

        /// <summary>Map to "avatar_url"</summary>
        Uri AvatarUri { [Pure] get; }

        /// <summary>Map to "gravatar_id"</summary>
        String GravatarId { [Pure] get; }

        /// <summary>Map to "url"</summary>
        Uri Uri { [Pure] get; }

        /// <summary>Map to "html_url"</summary>
        Uri HtmlUri { [Pure] get; }

        /// <summary>Map to "followers_url"</summary>
        Uri FollowersUri { [Pure] get; }

        /// <summary>Map to "following_url"</summary>
        String FollowingUri { [Pure] get; }

        /// <summary>Map to "gists_url"</summary>
        String GistsUri { [Pure] get; }

        /// <summary>Map to "starred_url"</summary>
        String StarredUri { [Pure] get; }

        /// <summary>Map to "subscriptions_url"</summary>
        Uri SubscriptionsUri { [Pure] get; }

        /// <summary>Map to "organizations_url"</summary>
        Uri OrganizationsUri { [Pure] get; }

        /// <summary>Map to "repos_url"</summary>
        Uri RepositoriesUri { [Pure] get; }

        /// <summary>Map to "events_url"</summary>
        String EventUri { [Pure] get; }

        /// <summary>Map to "received_events_url"</summary>
        Uri ReceivedEventsUri { [Pure] get; }

        /// <summary>Map to "type"</summary>
        String Type { [Pure] get; }

        /// <summary>Map to "site_admin"</summary>
        Boolean SiteAdministrator { [Pure] get; }

    }
}
