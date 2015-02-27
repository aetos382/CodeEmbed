using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    using CodeEmbed.GitHubClient.Collections;

    interface IGistSummary<out TGistFile>
        where TGistFile : IGistFile
    {
        string Id { get; }

        IOutputDictionary<string, TGistFile> Files { get; }
    }
}
