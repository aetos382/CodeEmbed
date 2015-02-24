using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    using Newtonsoft.Json;

    class SerializableGistSummary :
        SerializableGistBase,
        IGistSummary<SerializableGistFile>
    {
        private readonly IOutputDictionary<string, SerializableGistFile> _files;

        [JsonConstructor]
        public SerializableGistSummary(
            string id,
            IOutputDictionary<string, SerializableGistFile> files)
            : base(id)
        {
            this._files = files;
        }

        [JsonProperty("file")]
        public IOutputDictionary<string, SerializableGistFile> Files
        {
            get
            {
                return this._files;
            }
        }
    }
}
