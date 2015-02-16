﻿namespace CodeEmbed.GitHubClient.Models
{
    //// GET /gists/:id

    using System;
    using System.Collections.Generic;
    using System.Linq;

    using CodeEmbed.GitHubClient.Models.Internal;

    public class Gist :
        IGist
    {
        public Uri Uri { get; set; }

        public string Id { get; set; }

        public string Description { get; set; }

        public IDictionary<string, IGistFile> Files { get; set; } 

        public IList<IGistHistory> Histories { get; set; }
    }
}
