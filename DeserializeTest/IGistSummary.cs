using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    interface IGistSummary<out TGistFile> : IGistBase
        where TGistFile : IGistFile
    {
        IDictionary<string, TGistFile> Files { get; }
    }
}
