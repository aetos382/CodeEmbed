namespace CodeEmbed.GitHubClient.Models.Internal
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IGistFile
    {
        string FileName { [Pure] get; }

        string Type { [Pure] get; }

        string Language { [Pure] get; }

        long Size { [Pure] get; }

        Uri RawUri { [Pure] get; }

        bool Truncated { [Pure] get; }

        string Content { [Pure] get; }
    }
}
