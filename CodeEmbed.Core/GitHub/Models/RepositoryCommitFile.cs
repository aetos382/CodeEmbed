namespace CodeEmbed.Core.GitHub.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    
    using Newtonsoft.Json;

    [JsonObject]
    public class RepositoryCommitFile
    {
        [JsonProperty("sha")]
        public string Hash { get; set; }

        [JsonProperty("filename")]
        public string FileName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("additions")]
        public int Additions { get; set; }

        [JsonProperty("deletions")]
        public int Deletions { get; set; }

        [JsonProperty("changes")]
        public int Changes { get; set; }

        [JsonProperty("blob_url")]
        public Uri BlobUri { get; set; }

        [JsonProperty("raw_url")]
        public Uri RawUri { get; set; }

        [JsonProperty("contents_url")]
        public Uri ContentsUri { get; set; }

        [JsonProperty("patch")]
        public string Patch { get; set; }
    }
}
