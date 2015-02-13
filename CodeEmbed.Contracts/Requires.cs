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

    public static class Requires
    {
        [ContractAbbreviator]
        [DebuggerStepThrough]
        [DebuggerHidden]
        public static void ArgumentNotNull<T>(T argument)
        {
            Contract.Requires<ArgumentNullException>(argument != null);
        }

        [ContractAbbreviator]
        [DebuggerStepThrough]
        [DebuggerHidden]
        public static void StringNotNullOrEmpty(string argument)
        {
            Contract.Requires<ArgumentNullException>(argument != null);
            Contract.Requires<ArgumentException>(!string.IsNullOrEmpty(argument));
        }

        [ContractAbbreviator]
        [DebuggerStepThrough]
        [DebuggerHidden]
        public static void NotContainNull(IEnumerable collection)
        {
            Contract.Requires<ArgumentNullException>(collection != null);
            Contract.Requires<ArgumentNullException>(Contract.ForAll(collection.Cast<object>(), x => x != null));
        }
    }
}
