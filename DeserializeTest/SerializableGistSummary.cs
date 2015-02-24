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
        private readonly SerializableGistFile _file;

        [JsonConstructor]
        public SerializableGistSummary(
            string id,
            SerializableGistFile file)
            : base(id)
        {
            this._file = file;
        }

        [JsonProperty("file")]
        public SerializableGistFile File
        {
            get
            {
                return this._file;
            }
        }
    }
}
