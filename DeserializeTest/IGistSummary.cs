namespace DeserializeTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    interface IGistSummary : IGistBase
    {
        IReadOnlyDictionary<string, IGistFile> Files { get; }
    }
}
