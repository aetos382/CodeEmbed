using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    public interface IOutputKeyValuePair<out TKey, out TValue>
    {
        TKey Key { get; }

        TValue Value { get; }
    }
}
