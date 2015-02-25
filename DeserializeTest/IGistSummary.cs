using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    interface IGistSummary<out TGistFile, out TFoo> : IGistBase<TFoo>
        where TGistFile : IGistFile
        where TFoo : IFoo
    {
        IOutputDictionary<string, TGistFile> Files { get; }
    }
}
