namespace DeserializeTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Gist :
        IGist
    {
        private readonly IGist _gist;

        private readonly IReadOnlyDictionary<string, GistFileContent> _files;

        private readonly IEnumerable<GistFork> _forks; 

        public Gist(IGist gist)
        {
            this._gist = gist;
            this._files = gist.Files.ToDictionary(x => x.Key, x => new GistFileContent(x.Value));
            this._forks = gist.Forks.Select(x => new GistFork(x));
        }

        public string Id
        {
            get
            {
                return this._gist.Id;
            }
        }

        public IReadOnlyDictionary<string, GistFileContent> Files
        {
            get
            {
                return this._files;
            }
        }

        public IEnumerable<GistFork> Forks
        {
            get
            {
                return this._forks;
            }
        }

        IReadOnlyDictionary<string, IGistFileContent> IGist.Files
        {
            get
            {
                return this._gist.Files;
            }
        }

        IEnumerable<IGistFork> IGist.Forks
        {
            get
            {
                return this._gist.Forks;
            }
        }
    }
}
