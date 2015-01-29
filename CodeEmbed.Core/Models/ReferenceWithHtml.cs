namespace CodeEmbed.GitHub.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    [JsonObject]
    public class ReferenceWithHtml : Reference
    {
        [JsonProperty("html_url")]
        public Uri HtmlUri { get; set; }
    }
}
