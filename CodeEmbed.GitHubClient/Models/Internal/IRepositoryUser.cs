﻿namespace CodeEmbed.GitHubClient.Models.Internal
{
    using System;
    using System.Diagnostics.Contracts;
    using System.Linq;

    public interface IRepositoryUser
    {
        string Login { [Pure] get; }

        long Id { [Pure] get; }

        Uri AvatarUri { [Pure] get; }

        string GravatarId { [Pure] get; }

        Uri Uri { [Pure] get; }

        Uri HtmlUri { [Pure] get; }

        Uri FollowersUri { [Pure] get; }

        UriTemplate FollowingUri { [Pure] get; }

        UriTemplate GistsUri { [Pure] get; }

        UriTemplate StarredUri { [Pure] get; }

        UriTemplate SubscriptionsUri { [Pure] get; }

        Uri OrganizationsUri { [Pure] get; }

        Uri RepositoriesUri { [Pure] get; }

        UriTemplate EventsUri { [Pure] get; }

        Uri ReceiedEventsUri { [Pure] get; }

        string Type { [Pure] get; }

        bool SiteAdmin { [Pure] get; }
    }
}
