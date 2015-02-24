using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    class GistFileContent :
        GistFile,
        IGistFileContent
    {
        private readonly IGistFileContent _gistFileContent;

        public GistFileContent(IGistFileContent gistFileContent)
            : base(gistFileContent)
        {
            this._gistFileContent = gistFileContent;
        }
        
        public string Content
        {
            get
            {
                return this._gistFileContent.Content;
            }
        }
    }
}
