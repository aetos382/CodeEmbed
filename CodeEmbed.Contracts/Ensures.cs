namespace CodeEmbed.Contracts
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class Ensures
    {
        [DebuggerStepThrough]
        [DebuggerHidden]
        [ContractAbbreviator]
        public static void ResultIsNotNull<T>()
        {
            Contract.Ensures(Contract.Result<T>() != null);
        }

        [DebuggerStepThrough]
        [DebuggerHidden]
        [ContractAbbreviator]
        public static void StringIsNotNullOrEmpty()
        {
            Contract.Ensures(Contract.Result<string>() != null);
            Contract.Ensures(!string.IsNullOrEmpty(Contract.Result<string>()));
        }

        [DebuggerStepThrough]
        [DebuggerHidden]
        [ContractAbbreviator]
        public static void NotContainNull()
        {
            Contract.Ensures(Contract.Result<IEnumerable>() != null);
            Contract.Ensures(Contract.ForAll(Contract.Result<IEnumerable>().Cast<object>(), x => x != null));
        }
    }
}
