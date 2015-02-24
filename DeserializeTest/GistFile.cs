using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    class GistFile :
        IGistFile
    {
        private readonly IGistFile _gistFile;

        public GistFile(IGistFile gistFile)
        {
            this._gistFile = gistFile;
        }

        public string FileName
        {
            get
            {
                return this._gistFile.FileName;
            }
        }
    }
}
