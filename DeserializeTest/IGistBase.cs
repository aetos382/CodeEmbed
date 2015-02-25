using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    interface IGistBase<out TFoo>
        where TFoo : IFoo
    {
        string Id { get; }

        TFoo Foo { get; }
    }
}
