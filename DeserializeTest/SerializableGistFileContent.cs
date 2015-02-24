using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    using Newtonsoft.Json;

    class SerializableGistFileContent :
        SerializableGistFile,
        IGistFileContent
    {
        private readonly string _content;

        [JsonConstructor]
        public SerializableGistFileContent(
            string fileName,
            string content)
            : base(fileName)
        {
            this._content = content;
        }
        
        [JsonProperty("content")]
        public string Content
        {
            get
            {
                return this._content;
            }
        }
    }
}
