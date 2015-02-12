namespace CodeEmbed.Contracts
{
    using System;
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
    }
}
