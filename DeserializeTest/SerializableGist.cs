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
        IGist<SerializableGistFileContent>
    {
        private readonly SerializableGistFileContent _file;
        
        private readonly DateTime _createdAt;

        [JsonConstructor]
        public SerializableGist(
            string id,
            SerializableGistFileContent file,
            DateTime createdAt)
            : base(id)
        {
            this._file = file;
            this._createdAt = createdAt;
        }

        [JsonProperty("file")]
        public SerializableGistFileContent File
        {
            get
            {
                return this._file;
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
