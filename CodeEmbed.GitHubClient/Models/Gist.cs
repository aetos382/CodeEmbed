namespace CodeEmbed.GitHubClient.Models
{
    //// GET /gists/:id

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    using CodeEmbed.GitHubClient.Models.Internal;

    [DataContract]
    public class Gist
    {
        public Uri Uri { get; set; }

        public string Id { get; set; }

        public string Description { get; set; }

        public IDictionary<string, GistFile> Files { get; set; } 

        public IList<GistHistory> Histories { get; set; }
    }
}
