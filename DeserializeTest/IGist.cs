using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    interface IGist<out TGistFile, out TFoo> :
        IGistSummary<TGistFile, TFoo>
        where TGistFile : IGistFileContent
        where TFoo : IFoo
    {
        DateTime CreatedAt { get; }
    }
}
