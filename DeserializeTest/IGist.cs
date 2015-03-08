namespace DeserializeTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    interface IGist :
        IGistBase
    {
        IReadOnlyDictionary<string, IGistFileContent> Files { get; }

        IEnumerable<IGistFork> Forks { get; }
    }
}
