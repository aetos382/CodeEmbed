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
        private readonly IGistFile _file;

        public GistFile(IGistFile file)
        {
            this._file = file;
        }

        public string FileName
        {
            get
            {
                return _file.FileName;
            }
        }
    }
}
