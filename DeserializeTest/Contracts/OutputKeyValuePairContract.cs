using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeserializeTest.Contracts
{
    using System.Diagnostics.Contracts;

    [ContractClassFor(typeof(IOutputKeyValuePair<,>))]
    public abstract class OutputKeyValuePairContract<TKey, TValue> :
        IOutputKeyValuePair<TKey, TValue>
    {
        public TKey Key
        {
            get
            {
                Contract.Ensures(Contract.Result<TKey>() != null);

                throw new NotImplementedException();
            }
        }

        public abstract TValue Value { get; }
    }
}
