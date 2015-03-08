namespace DeserializeTest
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class GistSummary :
        IGistSummary
    {
        private readonly IGistSummary _gistSummary;

        private readonly IReadOnlyDictionary<string, GistFile> _files; 

        public GistSummary(IGistSummary gistSummary)
        {
            this._gistSummary = gistSummary;

            this._files = gistSummary.Files.ToDictionary(x => x.Key, x => new GistFile(x.Value));
        }

        public string Id
        {
            get
            {
                return this._gistSummary.Id;
            }
        }

        public IReadOnlyDictionary<string, GistFile> Files
        {
            get
            {
                return this._files;
            }
        }

        IReadOnlyDictionary<string, IGistFile> IGistSummary.Files
        {
            get
            {
                return this._gistSummary.Files;
            }
        }
    }
}
