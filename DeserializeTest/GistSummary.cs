using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    class GistSummary :
        GistBase,
        IGistSummary<GistFile>
    {
        private readonly IGistSummary<IGistFile> _gistSummary;

        private readonly IOutputDictionary<string, GistFile> _files;

        public GistSummary(
            IGistSummary<IGistFile> gistSummary)
            : base(gistSummary)
        {
            this._gistSummary = gistSummary;
            this._files = gistSummary.Files.ToOutputDictionary(x => x.Key, x => new GistFile(x.Value));
        }

        public IOutputDictionary<string, GistFile> Files
        {
            get
            {
                return this._files;
            }
        }
    }
}
