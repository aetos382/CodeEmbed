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
    class SerializableGistSummary :
        IGistSummary<SerializableGistFile>
    {
        private string _id;

        private readonly IOutputDictionary<string, SerializableGistFile> _files;

        [JsonConstructor]
        public SerializableGistSummary(
            string id,
            IOutputDictionary<string, SerializableGistFile> files)
        {
            this._id = id;

            this._files = files;
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
        public IOutputDictionary<string, SerializableGistFile> Files
        {
            get
            {
                return this._files;
            }
        }
    }
}
