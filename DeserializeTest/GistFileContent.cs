namespace DeserializeTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class GistFileContent :
        GistFile,
        IGistFileContent
    {
        private readonly IGistFileContent _content;

        public GistFileContent(IGistFileContent content)
            : base(content)
        {
            this._content = content;
        }

        public string Content
        {
            get
            {
                return _content.Content;
            }
        }
    }
}
