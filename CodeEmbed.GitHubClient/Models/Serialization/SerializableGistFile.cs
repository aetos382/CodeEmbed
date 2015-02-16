namespace CodeEmbed.GitHubClient.Models.Serialization
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CodeEmbed.GitHubClient.Models.Internal;

    public class SerializableGistFile :
        IGistFile
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
