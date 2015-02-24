using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    class Gist :
        GistBase,
        IGist<GistFileContent>
    {
        private readonly IGist<IGistFileContent> _gist;

        private readonly GistFileContent _file;

        public Gist(IGist<IGistFileContent> gist)
            : base(gist)
        {
            this._gist = gist;
            this._file = new GistFileContent(gist.File);
        }

        public GistFileContent File
        {
            get
            {
                return this._file;
            }
        }

        public DateTime CreatedAt
        {
            get
            {
                return this._gist.CreatedAt;
            }
        }
    }
}
