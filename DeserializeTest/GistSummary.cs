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

        private readonly GistFile _file;

        public GistSummary(IGistSummary<IGistFile> gistSummary)
            : base(gistSummary)
        {
            this._gistSummary = gistSummary;
            this._file = new GistFile(gistSummary.File);
        }

        public GistFile File
        {
            get
            {
                return this._file;
            }
        }
    }
}
