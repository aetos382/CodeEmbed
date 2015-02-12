namespace CodeEmbed.Configuration.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CodeEmbed.Contracts;

    [ContractClassFor(typeof(IConfigurationSource))]
    public abstract class ConfigurationSourceContracts :
        IConfigurationSource
    {
        public IDictionary<string, string> Values
        {
            [DebuggerStepThrough]
            [DebuggerHidden]
            [Pure]
            get
            {
                Ensures.ResultIsNotNull<IDictionary<string, string>>();

                throw new NotImplementedException();
            }
        }

        public abstract void Refresh();
    }
}
