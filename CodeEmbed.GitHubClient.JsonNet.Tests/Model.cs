﻿namespace CodeEmbed.GitHubClient.JsonNet.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    [JsonObject]
    internal class Model :
        IModel
    {
        [JsonProperty]
        public string Name { get; set; }
    }
}
