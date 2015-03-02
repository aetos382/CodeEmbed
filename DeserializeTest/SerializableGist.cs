using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    using CodeEmbed.GitHubClient.Collections;

    using Newtonsoft.Json;

    [JsonObject]
    class SerializableGist :
        IGist<SerializableGistFileContent, SerializableGistFork>
    {
        private readonly string _id;

        private readonly IOutputDictionary<string, SerializableGistFileContent> _files;

        private readonly IEnumerable<SerializableGistFork> _forks;

        [JsonConstructor]
        public SerializableGist(
            string id,
            IOutputDictionary<string, SerializableGistFileContent> files,
            IEnumerable<SerializableGistFork> forks)
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
        public IOutputDictionary<string, SerializableGistFileContent> Files
        {
            get
            {
                return this._files;
            }
        }

        [JsonProperty("forks")]
        public IEnumerable<SerializableGistFork> Forks
        {
            get
            {
                return this._forks;
            }
        }
    }
}
