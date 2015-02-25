using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    abstract class GistBase
        : IGistBase<Foo>
    {
        private readonly IGistBase<IFoo> _gistBase;

        protected GistBase(IGistBase<IFoo> gistBase)
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

        public Foo Foo
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
