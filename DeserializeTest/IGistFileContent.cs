using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    interface IGistFileContent :
        IGistFile
    {
        string Content { get; }
    }
}
