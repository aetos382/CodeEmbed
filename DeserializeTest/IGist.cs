using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    interface IGist<out TGistFile, out TGistFork> :
        IGistSummary<TGistFile>
        where TGistFile : IGistFileContent
        where TGistFork : IGistFork<IRepositoryUser>
    {
        IEnumerable<TGistFork> Forks { get; }
    }
}
