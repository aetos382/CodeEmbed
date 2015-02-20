namespace CodeEmbed.GitHubClient.Models
{
    using System;

    using CodeEmbed.GitHubClient.Serialization;

    using Newtonsoft.Json;

    [JsonConverter(typeof(CamelCaseStringEnumConverter))]
    public enum GitObjectType
    {
        Commit,
        Blob,
        Tree,
        Tag
    }
}
