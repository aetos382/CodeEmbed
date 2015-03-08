namespace DeserializeTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    [JsonObject]
    class SerializableGistSummary :
        IGistSummary
    {
        private string _id;

        private readonly IReadOnlyDictionary<string, IGistFile> _files;

        [JsonConstructor]
        public SerializableGistSummary(
            string id,
            IReadOnlyDictionary<string, IGistFile> files)
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
        public IReadOnlyDictionary<string, IGistFile> Files
        {
            get
            {
                return this._files;
            }
        }
    }
}
