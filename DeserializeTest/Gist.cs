using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    using CodeEmbed.GitHubClient.Collections;

    class Gist :
        IGist<GistFileContent, GistFork, RepositoryUser>
    {
        private readonly IGist<IGistFileContent, IGistFork<IRepositoryUser>, IRepositoryUser> _gist;

        private readonly IOutputDictionary<string, GistFileContent> _files;

        private readonly IEnumerable<GistFork> _forks; 

        public Gist(IGist<IGistFileContent, IGistFork<IRepositoryUser>, IRepositoryUser> gist)
        {
            this._gist = gist;
            this._files = gist.Files.ToOutputDictionary(x => x.Key, x => new GistFileContent(x.Value));
            this._forks = gist.Forks.Select(x => new GistFork(x));
        }

        public string Id
        {
            get
            {
                return this._gist.Id;
            }
        }

        public IOutputDictionary<string, GistFileContent> Files
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
    }
}
