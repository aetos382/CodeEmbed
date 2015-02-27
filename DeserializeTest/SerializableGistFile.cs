using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    using Newtonsoft.Json;

    [JsonObject]
    class SerializableGistFile :
        IGistFile
    {
        private readonly string _fileName;

        [JsonConstructor]
        public SerializableGistFile(
            string fileName)
        {
            this._fileName = fileName;
        }

        [JsonProperty("file_name")]
        public string FileName
        {
            get
            {
                return this._fileName;
            }
        }
    }
}
