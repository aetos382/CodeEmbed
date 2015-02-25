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
        SerializableGistBase,
        IGist<SerializableGistFileContent, SerializableFoo>
    {
        private readonly IOutputDictionary<string, SerializableGistFileContent> _files;
        
        private readonly DateTime _createdAt;

        [JsonConstructor]
        public SerializableGist(
            string id,
            IOutputDictionary<string, SerializableGistFileContent> files,
            DateTime createdAt)
            : base(id)
        {
            this._files = files;
            this._createdAt = createdAt;
        }

        [JsonProperty("files")]
        public IOutputDictionary<string, SerializableGistFileContent> Files
        {
            get
            {
                return this._files;
            }
        }

        [JsonProperty("created_at")]
        public DateTime CreatedAt
        {
            get
            {
                return this._createdAt;
            }
        }
    }
}
