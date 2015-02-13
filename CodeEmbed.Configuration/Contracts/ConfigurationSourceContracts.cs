namespace CodeEmbed.Configuration.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [ContractClassFor(typeof(IConfigurationSource))]
    [DebuggerStepThrough]
    public abstract class ConfigurationSourceContracts :
        IConfigurationSource
    {
        public IDictionary<string, string> Values
        {
            [DebuggerHidden]
            [Pure]
            get
            {
                Contract.Ensures(Contract.Result<IDictionary<string, string>>() != null);

                throw new NotImplementedException();
            }
        }

        public abstract void Refresh();
    }
}
