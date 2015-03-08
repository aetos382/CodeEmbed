using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    using Newtonsoft.Json;

    [JsonObject]
    class SerializableGist :
        IGist
    {
        private readonly string _id;

        private readonly IReadOnlyDictionary<string, IGistFileContent> _files;

        private readonly IEnumerable<IGistFork> _forks;

        [JsonConstructor]
        public SerializableGist(
            string id,
            IReadOnlyDictionary<string, IGistFileContent> files,
            IEnumerable<IGistFork> forks)
        {
            this._id = id;

            this._files = files;

            this._forks = forks;
        }

        [JsonProperty("id")]
        public string Id
        {
            get
            {
                return this._id;
            }
        }

        [JsonProperty("files")]
        public IReadOnlyDictionary<string, IGistFileContent> Files
        {
            get
            {
                return this._files;
            }
        }

        [JsonProperty("forks")]
        public IEnumerable<IGistFork> Forks
        {
            get
            {
                return this._forks;
            }
        }
    }
}
