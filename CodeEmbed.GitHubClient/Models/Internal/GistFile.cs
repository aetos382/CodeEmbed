namespace CodeEmbed.GitHubClient.Models.Internal
{
    using System;
    using System.Linq;
 
    public class GistFile
    {
        public string FileName { get; set; }

        public string Type { get; set; }

        public string Language { get; set; }

        public long Size { get; set; }

        public Uri RawUri { get; set; }

        public bool Truncated { get; set; }

        public string Content { get; set; }
    }
}
