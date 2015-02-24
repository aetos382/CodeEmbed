using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    abstract class GistBase
    {
        private readonly IGistBase _gistBase;

        protected GistBase(IGistBase gistBase)
        {
            this._gistBase = gistBase;
        }

        public string Id
        {
            get
            {
                return this._gistBase.Id;
            }
        }
    }
}
