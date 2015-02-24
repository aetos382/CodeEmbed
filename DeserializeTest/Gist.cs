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

        private readonly IOutputDictionary<string, GistFileContent> _files;

        public Gist(IGist<IGistFileContent> gist)
            : base(gist)
        {
            this._gist = gist;
            this._files = gist.Files.ToOutputDictionary(x => x.Key, x => new GistFileContent(x.Value));
        }

        public IOutputDictionary<string, GistFileContent> Files
        {
            get
            {
                return this._files;
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
