namespace CodeEmbed.GitHubClient.Models.Serialization
{
    using System;

    using CodeEmbed.GitHubClient.Models.Internal;

    using Newtonsoft.Json;

    [JsonObject]
    public class SerializableRepositoryUser :
        IRepositoryUser
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("avatar_url")]
        public Uri AvatarUri { get; set; }

        [JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty("url")]
        public Uri Uri { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUri { get; set; }

        [JsonProperty("followers_url")]
        public Uri FollowersUri { get; set; }

        [JsonProperty("following_url")]
        public UriTemplate FollowingUri { get; set; }

        [JsonProperty("gists_url")]
        public UriTemplate GistsUri { get; set; }

        [JsonProperty("starred_url")]
        public UriTemplate StarredUri { get; set; }

        [JsonProperty("subscriptions_url")]
        public UriTemplate SubscriptionsUri { get; set; }

        [JsonProperty("organizations_url")]
        public Uri OrganizationsUri { get; set; }

        [JsonProperty("repos_url")]
        public Uri RepositoriesUri { get; set; }

        [JsonProperty("events_url")]
        public UriTemplate EventsUri { get; set; }

        [JsonProperty("received_events_url")]
        public Uri ReceiedEventsUri { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }
    }
}
