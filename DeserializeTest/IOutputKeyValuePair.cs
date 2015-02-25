﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest
{
    using System.Diagnostics.Contracts;

    using DeserializeTest.Contracts;

    [ContractClass(typeof(OutputKeyValuePairContract<,>))]
    public interface IOutputKeyValuePair<out TKey, out TValue>
    {
        TKey Key { [Pure] get; }

        TValue Value { [Pure] get; }
    }
}
