using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    interface IGist<out TGistFile> :
        IGistSummary<TGistFile>
        where TGistFile : IGistFileContent
    {
        DateTime CreatedAt { get; }
    }
}
